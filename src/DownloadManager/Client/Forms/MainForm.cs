// Created by Anton Piruev in 2026.
// Any direct commercial use of derivative work is strictly prohibited.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Client.Models;

namespace Client
{
  public partial class MainForm : Form
  {
    private const int AnimationIntervalMs = 16;
    private const float AnimationLerpFactor = 0.15f;
    private const int CornerRadiusProgress = 6;
    private const int CornerRadiusStatus = 10;

    private static readonly Color ColorRowHovered = Color.FromArgb(48, 48, 52);
    private static readonly Color ColorRowSelected = Color.FromArgb(60, 60, 64);
    private static readonly Color ColorProgressTrack = Color.FromArgb(58, 58, 60);
    private static readonly Color ColorAccentBlue = Color.FromArgb(10, 132, 255);
    private static readonly Color ColorAccentGreen = Color.FromArgb(50, 215, 75);
    private static readonly Color ColorAccentRed = Color.FromArgb(255, 69, 58);
    private static readonly Color ColorAccentGray = Color.FromArgb(142, 142, 147);
    private static readonly Color ColorTextPrimary = Color.FromArgb(235, 235, 245);
    private static readonly Color ColorTextSecondary = Color.FromArgb(142, 142, 147);

    private Timer _animationTimer;
    private readonly Dictionary<DataGridViewRow, float> _animatedProgress = new Dictionary<DataGridViewRow, float>();
    private readonly Dictionary<string, Image> _fileIconCache = new Dictionary<string, Image>();
    private readonly Dictionary<string, Image> _faviconCache = new Dictionary<string, Image>();

    private int _hoveredRowIndex = -1;

    public MainForm()
    {
      InitializeComponent();

      dgvQueue.CellPainting += DgvQueue_CellPainting;

      StartProgressAnimation();
      SubscribeHoverEvents();

      SetWcfConnectionStatus(connected: true);
    }

    #region Hover tracking

    private void SubscribeHoverEvents()
    {
      dgvQueue.CellMouseEnter += (s, e) => SetHoveredRow(e.RowIndex);
      dgvQueue.CellMouseLeave += (s, e) => SetHoveredRow(-1);
    }

    private void SetHoveredRow(int rowIndex)
    {
      _hoveredRowIndex = rowIndex;
      dgvQueue.Invalidate();
    }

    #endregion

    #region Progress animation

    private void StartProgressAnimation()
    {
      _animationTimer = new Timer { Interval = AnimationIntervalMs };
      _animationTimer.Tick += OnAnimationTick;
      _animationTimer.Start();
    }

    private void OnAnimationTick(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgvQueue.Rows)
        AnimateRowProgress(row);

      dgvQueue.InvalidateColumn(dgvQueue.Columns["colQProgress"].Index);
    }

    private void AnimateRowProgress(DataGridViewRow row)
    {
      if (row.Cells["colQProgress"].Value == null)
        return;

      int targetProgress = Convert.ToInt32(row.Cells["colQProgress"].Value);

      if (!_animatedProgress.ContainsKey(row))
        _animatedProgress[row] = targetProgress;

      float current = _animatedProgress[row];
      _animatedProgress[row] = current + (targetProgress - current) * AnimationLerpFactor;
    }

    #endregion

    #region Icon and favicon loading

    private Image GetFileIcon(string filePath)
    {
      string extension = System.IO.Path.GetExtension(filePath);

      if (_fileIconCache.ContainsKey(extension))
        return _fileIconCache[extension];

      Icon icon = Icon.ExtractAssociatedIcon(filePath);
      Image bitmap = icon != null ? icon.ToBitmap() : null;
      _fileIconCache[extension] = bitmap;

      return bitmap;
    }

    private async void LoadFaviconAsync(string domain)
    {
      if (_faviconCache.ContainsKey(domain))
        return;

      try
      {
        using (var httpClient = new System.Net.Http.HttpClient())
        {
          string url = $"https://www.google.com/s2/favicons?domain={domain}&sz=32";
          var stream = await httpClient.GetStreamAsync(url);

          _faviconCache[domain] = Image.FromStream(stream);
          dgvQueue.Invalidate();
        }
      }
      catch { }
    }

    #endregion

    #region Cell painting dispatch

    private void DgvQueue_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.RowIndex < 0)
        return;

      var grid = (DataGridView)sender;
      var row = grid.Rows[e.RowIndex];

      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

      PaintCellBackground(e, row);

      string columnName = grid.Columns[e.ColumnIndex].Name;

      switch (columnName)
      {
        case "colQFile":
          PaintFileCell(e, row);
          break;
        case "colQProgress":
          PaintProgressCell(e, row);
          break;
        case "colQStatus":
          PaintStatusBadgeCell(e);
          break;
        default:
          e.Handled = false;
          break;
      }
    }

    #endregion

    #region Cell background

    private void PaintCellBackground(DataGridViewCellPaintingEventArgs e, DataGridViewRow row)
    {
      Color backgroundColor = e.CellStyle.BackColor;

      if (e.RowIndex == _hoveredRowIndex)
        backgroundColor = ColorRowHovered;

      if (row.Selected)
        backgroundColor = ColorRowSelected;

      using (var brush = new SolidBrush(backgroundColor))
        e.Graphics.FillRectangle(brush, e.CellBounds);
    }

    #endregion

    #region File cell

    private void PaintFileCell(DataGridViewCellPaintingEventArgs e, DataGridViewRow row)
    {
      e.Handled = true;

      Rectangle bounds = e.CellBounds;
      bounds.Inflate(-12, -6);

      int cursorX = bounds.X;
      cursorX = TryDrawFileIcon(e.Graphics, row, bounds, cursorX);
      cursorX = TryDrawFavicon(e.Graphics, row, bounds, cursorX);

      string fileName = Convert.ToString(e.Value) ?? "file.ext";
      DrawFileCellText(e.Graphics, row, bounds, cursorX, fileName);
    }

    private int TryDrawFileIcon(Graphics g, DataGridViewRow row, Rectangle bounds, int cursorX)
    {
      var item = row.Tag as DownloadItem;
      if (item == null)
        return cursorX;

      Image icon = GetFileIcon(item.FileName);
      if (icon == null)
        return cursorX;

      g.DrawImage(icon, cursorX, bounds.Y + 6, 20, 20);
      return cursorX + 26;
    }

    private int TryDrawFavicon(Graphics g, DataGridViewRow row, Rectangle bounds, int cursorX)
    {
      var item = row.Tag as DownloadItem;
      if (item == null)
        return cursorX;

      if (!_faviconCache.ContainsKey(item.Domain))
        LoadFaviconAsync(item.Domain);

      Image favicon;
      if (!_faviconCache.TryGetValue(item.Domain, out favicon))
        return cursorX;

      g.DrawImage(favicon, cursorX, bounds.Y + bounds.Height / 2, 16, 16);
      return cursorX + 20;
    }

    private void DrawFileCellText(Graphics g, DataGridViewRow row, Rectangle bounds, int cursorX, string fileName)
    {
      var item = row.Tag as DownloadItem;
      string domain = item != null ? item.Domain : "example.com";

      float textAreaWidth = bounds.Width - (cursorX - bounds.X);
      var topHalf = new RectangleF(cursorX, bounds.Y, textAreaWidth, bounds.Height / 2f);
      var bottomHalf = new RectangleF(cursorX, bounds.Y + bounds.Height / 2f, textAreaWidth, bounds.Height / 2f);

      using (var fontPrimary = new Font("Segoe UI", 9.5f))
      using (var fontSecondary = new Font("Segoe UI", 8f))
      using (var brushPrimary = new SolidBrush(ColorTextPrimary))
      using (var brushSecondary = new SolidBrush(ColorTextSecondary))
      {
        g.DrawString(fileName, fontPrimary, brushPrimary, topHalf);
        g.DrawString(domain, fontSecondary, brushSecondary, bottomHalf);
      }
    }

    #endregion

    #region Progress cell

    private void PaintProgressCell(DataGridViewCellPaintingEventArgs e, DataGridViewRow row)
    {
      e.Handled = true;

      float percent = GetAnimatedPercent(row, e.Value);

      Rectangle bounds = e.CellBounds;
      bounds.Inflate(-12, -14);

      DrawProgressTrack(e.Graphics, bounds);
      DrawProgressFill(e.Graphics, bounds, percent);
      DrawProgressLabel(e.Graphics, bounds, percent);
    }

    private float GetAnimatedPercent(DataGridViewRow row, object cellValue)
    {
      float raw;

      if (_animatedProgress.ContainsKey(row))
        raw = _animatedProgress[row];
      else if (cellValue != null)
        raw = Convert.ToSingle(cellValue);
      else
        raw = 0f;

      return Math.Max(0f, Math.Min(100f, raw));
    }

    private void DrawProgressTrack(Graphics g, Rectangle bounds)
    {
      using (var brush = new SolidBrush(ColorProgressTrack))
        FillRoundedRect(g, brush, bounds, CornerRadiusProgress);
    }

    private void DrawProgressFill(Graphics g, Rectangle bounds, float percent)
    {
      int fillWidth = (int)(bounds.Width * percent / 100f);
      if (fillWidth <= 0)
        return;

      var fillRect = new Rectangle(bounds.X, bounds.Y, fillWidth, bounds.Height);

      using (var brush = new SolidBrush(ColorAccentBlue))
        FillRoundedRect(g, brush, fillRect, CornerRadiusProgress);
    }

    private void DrawProgressLabel(Graphics g, Rectangle bounds, float percent)
    {
      using (var font = new Font("Segoe UI", 8.5f))
      using (var brush = new SolidBrush(Color.White))
      {
        var sf = new StringFormat
        {
          Alignment = StringAlignment.Center,
          LineAlignment = StringAlignment.Center
        };

        g.DrawString($"{(int)percent}%", font, brush, (RectangleF)bounds, sf);
      }
    }

    #endregion

    #region Status badge cell

    private void PaintStatusBadgeCell(DataGridViewCellPaintingEventArgs e)
    {
      e.Handled = true;

      string status = Convert.ToString(e.Value) ?? "Queued";

      Rectangle bounds = e.CellBounds;
      bounds.Inflate(-20, -12);

      using (var brush = new SolidBrush(GetStatusColor(status)))
        FillRoundedRect(e.Graphics, brush, bounds, CornerRadiusStatus);

      DrawStatusLabel(e.Graphics, bounds, status);
    }

    private Color GetStatusColor(string status)
    {
      switch (status)
      {
        case "Downloading": return ColorAccentBlue;
        case "Complete": return ColorAccentGreen;
        case "Failed": return ColorAccentRed;
        default: return ColorAccentGray;
      }
    }

    private void DrawStatusLabel(Graphics g, Rectangle bounds, string status)
    {
      using (var font = new Font("Segoe UI", 8.5f, FontStyle.Bold))
      using (var brush = new SolidBrush(Color.White))
      {
        var sf = new StringFormat
        {
          Alignment = StringAlignment.Center,
          LineAlignment = StringAlignment.Center
        };

        g.DrawString(status, font, brush, (RectangleF)bounds, sf);
      }
    }

    #endregion

    #region Rounded rectangle helper

    private void FillRoundedRect(Graphics g, Brush brush, Rectangle rect, int radius)
    {
      using (var path = new GraphicsPath())
      {
        int diameter = radius * 2;

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        g.FillPath(brush, path);
      }
    }

    #endregion

    #region WCF connection status

    private void SetWcfConnectionStatus(bool connected)
    {
      tsslWcfStatus.ForeColor = connected ? ColorAccentGreen : ColorAccentRed;
      tsslWcfStatus.Text = connected ? "connected" : "disconnected";
    }

    #endregion
  }
}
