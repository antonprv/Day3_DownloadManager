using System.Windows.Forms;

namespace Client
{
  public partial class MainForm : Form
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null) components.Dispose();
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();

      // ── Цвета тёмной темы ──────────────────────────────────────────────
      var clrBg = System.Drawing.Color.FromArgb(28, 28, 30); // фон формы
      var clrCard = System.Drawing.Color.FromArgb(44, 44, 46); // карточки / панели
      var clrBorder = System.Drawing.Color.FromArgb(58, 58, 60); // разделители
      var clrPri = System.Drawing.Color.FromArgb(235, 235, 245); // основной текст
      var clrSec = System.Drawing.Color.FromArgb(142, 142, 147); // вторичный текст
      var clrBlue = System.Drawing.Color.FromArgb(10, 132, 255); // акцент Add URL
      var clrRed = System.Drawing.Color.FromArgb(255, 69, 58); // Failed / Cancel all
      var clrRowAlt = System.Drawing.Color.FromArgb(33, 33, 36); // чётные строки DGV
      var clrSel = System.Drawing.Color.FromArgb(55, 55, 58); // выделение DGV

      // ── Инстанцирование всех контролов ────────────────────────────────
      this.pnlTop = new System.Windows.Forms.Panel();
      this.txtUrl = new System.Windows.Forms.TextBox();
      this.btnAddUrl = new System.Windows.Forms.Button();
      this.btnClearDone = new System.Windows.Forms.Button();
      this.btnCancelAll = new System.Windows.Forms.Button();

      this.pnlStats = new System.Windows.Forms.Panel();
      this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
      this.pnlStatCompleted = new System.Windows.Forms.Panel();
      this.lblCompletedNum = new System.Windows.Forms.Label();
      this.lblCompletedText = new System.Windows.Forms.Label();
      this.pnlStatDownloading = new System.Windows.Forms.Panel();
      this.lblDownloadingNum = new System.Windows.Forms.Label();
      this.lblDownloadingText = new System.Windows.Forms.Label();
      this.pnlStatQueued = new System.Windows.Forms.Panel();
      this.lblQueuedNum = new System.Windows.Forms.Label();
      this.lblQueuedText = new System.Windows.Forms.Label();
      this.pnlStatFailed = new System.Windows.Forms.Panel();
      this.lblFailedNum = new System.Windows.Forms.Label();
      this.lblFailedText = new System.Windows.Forms.Label();

      this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
      this.pnlQueueHeader = new System.Windows.Forms.Panel();
      this.lblQueueHeader = new System.Windows.Forms.Label();
      this.dgvQueue = new System.Windows.Forms.DataGridView();
      this.colQFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colQSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colQProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colQStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

      this.pnlHistoryHeader = new System.Windows.Forms.Panel();
      this.lblHistoryHeader = new System.Windows.Forms.Label();
      this.dgvHistory = new System.Windows.Forms.DataGridView();
      this.colHFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colHSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colHStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.tsslActive = new System.Windows.Forms.ToolStripStatusLabel();
      this.tssSep1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsslTotalDownloaded = new System.Windows.Forms.ToolStripStatusLabel();
      this.tssSep2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsslWcfLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslWcfStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.tssSep3 = new System.Windows.Forms.ToolStripSeparator();
      this.tsslDb = new System.Windows.Forms.ToolStripStatusLabel();

      // ── SuspendLayout — блокируем пересчёт раскладки до конца Init ──
      this.pnlTop.SuspendLayout();
      this.pnlStats.SuspendLayout();
      this.tlpStats.SuspendLayout();
      this.pnlStatCompleted.SuspendLayout();
      this.pnlStatDownloading.SuspendLayout();
      this.pnlStatQueued.SuspendLayout();
      this.pnlStatFailed.SuspendLayout();
      this.tlpMain.SuspendLayout();
      this.pnlQueueHeader.SuspendLayout();
      this.pnlHistoryHeader.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)this.dgvQueue).BeginInit();
      ((System.ComponentModel.ISupportInitialize)this.dgvHistory).BeginInit();
      this.SuspendLayout();

      // ═══════════════════════════════════════════════════════════════════
      // pnlTop — строка с полем URL и тремя кнопками
      // ═══════════════════════════════════════════════════════════════════
      this.pnlTop.BackColor = clrBg;
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Height = 72;
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Controls.AddRange(new System.Windows.Forms.Control[]
      {
                this.txtUrl, this.btnAddUrl, this.btnClearDone, this.btnCancelAll
      });

      // txtUrl
      this.txtUrl.Anchor = System.Windows.Forms.AnchorStyles.Top
                              | System.Windows.Forms.AnchorStyles.Left
                              | System.Windows.Forms.AnchorStyles.Right;
      this.txtUrl.BackColor = clrCard;
      this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtUrl.ForeColor = clrPri;
      this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 10.5F);
      this.txtUrl.Location = new System.Drawing.Point(12, 20);
      this.txtUrl.Name = "txtUrl";
      this.txtUrl.Size = new System.Drawing.Size(640, 32);
      this.txtUrl.TabIndex = 0;
      this.txtUrl.Text = "https://";
      // NOTE: граница txtUrl в тёмном стиле задаётся через WndProc или
      //       заменой на кастомный TextBox с OnPaint; FixedSingle — ближайший вариант

      // btnAddUrl — синяя кнопка-акцент
      this.btnAddUrl.Anchor = System.Windows.Forms.AnchorStyles.Top
                                                    | System.Windows.Forms.AnchorStyles.Right;
      this.btnAddUrl.BackColor = clrBlue;
      this.btnAddUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddUrl.FlatAppearance.BorderSize = 0;
      this.btnAddUrl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 145, 255);
      this.btnAddUrl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 112, 220);
      this.btnAddUrl.ForeColor = System.Drawing.Color.White;
      this.btnAddUrl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
      this.btnAddUrl.Location = new System.Drawing.Point(662, 20);
      this.btnAddUrl.Name = "btnAddUrl";
      this.btnAddUrl.Size = new System.Drawing.Size(96, 32);
      this.btnAddUrl.TabIndex = 1;
      this.btnAddUrl.Text = "Add URL";
      this.btnAddUrl.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAddUrl.UseVisualStyleBackColor = false;

      // btnClearDone — нейтральная кнопка с рамкой
      this.btnClearDone.Anchor = System.Windows.Forms.AnchorStyles.Top
                                                    | System.Windows.Forms.AnchorStyles.Right;
      this.btnClearDone.BackColor = clrCard;
      this.btnClearDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClearDone.FlatAppearance.BorderColor = clrBorder;
      this.btnClearDone.FlatAppearance.BorderSize = 1;
      this.btnClearDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(56, 56, 58);
      this.btnClearDone.ForeColor = clrPri;
      this.btnClearDone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
      this.btnClearDone.Location = new System.Drawing.Point(766, 20);
      this.btnClearDone.Name = "btnClearDone";
      this.btnClearDone.Size = new System.Drawing.Size(96, 32);
      this.btnClearDone.TabIndex = 2;
      this.btnClearDone.Text = "Clear done";
      this.btnClearDone.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClearDone.UseVisualStyleBackColor = false;

      // btnCancelAll — красная рамка и текст
      this.btnCancelAll.Anchor = System.Windows.Forms.AnchorStyles.Top
                                                    | System.Windows.Forms.AnchorStyles.Right;
      this.btnCancelAll.BackColor = clrCard;
      this.btnCancelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelAll.FlatAppearance.BorderColor = clrRed;
      this.btnCancelAll.FlatAppearance.BorderSize = 1;
      this.btnCancelAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(60, 30, 28);
      this.btnCancelAll.ForeColor = clrRed;
      this.btnCancelAll.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
      this.btnCancelAll.Location = new System.Drawing.Point(870, 20);
      this.btnCancelAll.Name = "btnCancelAll";
      this.btnCancelAll.Size = new System.Drawing.Size(96, 32);
      this.btnCancelAll.TabIndex = 3;
      this.btnCancelAll.Text = "Cancel all";
      this.btnCancelAll.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCancelAll.UseVisualStyleBackColor = false;

      // ═══════════════════════════════════════════════════════════════════
      // pnlStats — 4 статистических карточки
      // ═══════════════════════════════════════════════════════════════════
      this.pnlStats.BackColor = clrBg;
      this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlStats.Height = 92;
      this.pnlStats.Name = "pnlStats";
      this.pnlStats.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.pnlStats.Controls.Add(this.tlpStats);

      // tlpStats — равномерная сетка 4 × 1
      this.tlpStats.BackColor = clrBg;
      this.tlpStats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
      this.tlpStats.ColumnCount = 4;
      this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpStats.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpStats.Name = "tlpStats";
      this.tlpStats.RowCount = 1;
      this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpStats.Controls.Add(this.pnlStatCompleted, 0, 0);
      this.tlpStats.Controls.Add(this.pnlStatDownloading, 1, 0);
      this.tlpStats.Controls.Add(this.pnlStatQueued, 2, 0);
      this.tlpStats.Controls.Add(this.pnlStatFailed, 3, 0);

      // NOTE: для скруглённых углов карточек добавь в MainForm.cs:
      //   pnlStatXxx.Paint += (s, e) => DrawRoundedPanel((Panel)s, e.Graphics, 8);
      //   где DrawRoundedPanel рисует контур через e.Graphics.DrawPath

      // Карточка Completed
      this.pnlStatCompleted.BackColor = clrCard;
      this.pnlStatCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlStatCompleted.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
      this.pnlStatCompleted.Name = "pnlStatCompleted";
      this.pnlStatCompleted.Controls.AddRange(new System.Windows.Forms.Control[]
          { this.lblCompletedNum, this.lblCompletedText });

      this.lblCompletedNum.AutoSize = true;
      this.lblCompletedNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
      this.lblCompletedNum.ForeColor = clrPri;
      this.lblCompletedNum.Location = new System.Drawing.Point(16, 8);
      this.lblCompletedNum.Name = "lblCompletedNum";
      this.lblCompletedNum.Text = "0";

      this.lblCompletedText.AutoSize = true;
      this.lblCompletedText.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblCompletedText.ForeColor = clrSec;
      this.lblCompletedText.Location = new System.Drawing.Point(16, 46);
      this.lblCompletedText.Name = "lblCompletedText";
      this.lblCompletedText.Text = "Completed";

      // Карточка Downloading
      this.pnlStatDownloading.BackColor = clrCard;
      this.pnlStatDownloading.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlStatDownloading.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.pnlStatDownloading.Name = "pnlStatDownloading";
      this.pnlStatDownloading.Controls.AddRange(new System.Windows.Forms.Control[]
          { this.lblDownloadingNum, this.lblDownloadingText });

      this.lblDownloadingNum.AutoSize = true;
      this.lblDownloadingNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
      this.lblDownloadingNum.ForeColor = clrPri;
      this.lblDownloadingNum.Location = new System.Drawing.Point(16, 8);
      this.lblDownloadingNum.Name = "lblDownloadingNum";
      this.lblDownloadingNum.Text = "0";

      this.lblDownloadingText.AutoSize = true;
      this.lblDownloadingText.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblDownloadingText.ForeColor = clrSec;
      this.lblDownloadingText.Location = new System.Drawing.Point(16, 46);
      this.lblDownloadingText.Name = "lblDownloadingText";
      this.lblDownloadingText.Text = "Downloading";

      // Карточка Queued
      this.pnlStatQueued.BackColor = clrCard;
      this.pnlStatQueued.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlStatQueued.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.pnlStatQueued.Name = "pnlStatQueued";
      this.pnlStatQueued.Controls.AddRange(new System.Windows.Forms.Control[]
          { this.lblQueuedNum, this.lblQueuedText });

      this.lblQueuedNum.AutoSize = true;
      this.lblQueuedNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
      this.lblQueuedNum.ForeColor = clrPri;
      this.lblQueuedNum.Location = new System.Drawing.Point(16, 8);
      this.lblQueuedNum.Name = "lblQueuedNum";
      this.lblQueuedNum.Text = "0";

      this.lblQueuedText.AutoSize = true;
      this.lblQueuedText.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblQueuedText.ForeColor = clrSec;
      this.lblQueuedText.Location = new System.Drawing.Point(16, 46);
      this.lblQueuedText.Name = "lblQueuedText";
      this.lblQueuedText.Text = "Queued";

      // Карточка Failed — число красное
      this.pnlStatFailed.BackColor = clrCard;
      this.pnlStatFailed.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlStatFailed.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.pnlStatFailed.Name = "pnlStatFailed";
      this.pnlStatFailed.Controls.AddRange(new System.Windows.Forms.Control[]
          { this.lblFailedNum, this.lblFailedText });

      this.lblFailedNum.AutoSize = true;
      this.lblFailedNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
      this.lblFailedNum.ForeColor = clrRed;   // <── красный, остальные clrPri
      this.lblFailedNum.Location = new System.Drawing.Point(16, 8);
      this.lblFailedNum.Name = "lblFailedNum";
      this.lblFailedNum.Text = "0";

      this.lblFailedText.AutoSize = true;
      this.lblFailedText.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblFailedText.ForeColor = clrSec;
      this.lblFailedText.Location = new System.Drawing.Point(16, 46);
      this.lblFailedText.Name = "lblFailedText";
      this.lblFailedText.Text = "Failed";

      // ═══════════════════════════════════════════════════════════════════
      // tlpMain — основная область: заголовок + очередь + заголовок + история
      // ═══════════════════════════════════════════════════════════════════
      this.tlpMain.BackColor = clrBg;
      this.tlpMain.ColumnCount = 1;
      this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpMain.Name = "tlpMain";
      this.tlpMain.RowCount = 4;
      // Строка 0: "DOWNLOAD QUEUE" — фиксированная высота
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
      // Строка 1: таблица очереди — 57% оставшегося пространства
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
      // Строка 2: "HISTORY (FROM SERVER DB)" — фиксированная высота
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
      // Строка 3: таблица истории — 43% оставшегося пространства
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
      this.tlpMain.Controls.Add(this.pnlQueueHeader, 0, 0);
      this.tlpMain.Controls.Add(this.dgvQueue, 0, 1);
      this.tlpMain.Controls.Add(this.pnlHistoryHeader, 0, 2);
      this.tlpMain.Controls.Add(this.dgvHistory, 0, 3);

      // Заголовок "DOWNLOAD QUEUE"
      this.pnlQueueHeader.BackColor = clrBg;
      this.pnlQueueHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlQueueHeader.Name = "pnlQueueHeader";
      this.pnlQueueHeader.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
      this.pnlQueueHeader.Controls.Add(this.lblQueueHeader);

      this.lblQueueHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblQueueHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
      this.lblQueueHeader.ForeColor = clrSec;
      this.lblQueueHeader.Name = "lblQueueHeader";
      this.lblQueueHeader.Text = "DOWNLOAD QUEUE";
      this.lblQueueHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

      // Заголовок "HISTORY (FROM SERVER DB)"
      this.pnlHistoryHeader.BackColor = clrBg;
      this.pnlHistoryHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlHistoryHeader.Name = "pnlHistoryHeader";
      this.pnlHistoryHeader.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
      this.pnlHistoryHeader.Controls.Add(this.lblHistoryHeader);

      this.lblHistoryHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblHistoryHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
      this.lblHistoryHeader.ForeColor = clrSec;
      this.lblHistoryHeader.Name = "lblHistoryHeader";
      this.lblHistoryHeader.Text = "HISTORY (FROM SERVER DB)";
      this.lblHistoryHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

      // ═══════════════════════════════════════════════════════════════════
      // dgvQueue — таблица активных загрузок
      // ═══════════════════════════════════════════════════════════════════
      this.dgvQueue.AllowUserToAddRows = false;
      this.dgvQueue.AllowUserToDeleteRows = false;
      this.dgvQueue.AllowUserToResizeRows = false;
      this.dgvQueue.BackgroundColor = clrBg;
      this.dgvQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.dgvQueue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvQueue.ColumnHeadersHeight = 36;
      this.dgvQueue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvQueue.EnableHeadersVisualStyles = false;  // обязательно для кастомных стилей заголовков
      this.dgvQueue.GridColor = clrBorder;
      this.dgvQueue.MultiSelect = false;
      this.dgvQueue.Name = "dgvQueue";
      this.dgvQueue.ReadOnly = true;
      this.dgvQueue.RowHeadersVisible = false;
      this.dgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvQueue.ShowCellToolTips = false;
      // Высота строки: 56px = место для двустрочной ячейки (filename + domain)
      // Рендеринг двух строк — через CellPainting в MainForm.cs
      this.dgvQueue.RowTemplate.Height = 56;
      this.dgvQueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

      // Стиль заголовков столбцов
      var qHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
      qHeaderStyle.BackColor = clrCard;
      qHeaderStyle.ForeColor = clrSec;
      qHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
      qHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      qHeaderStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
      qHeaderStyle.SelectionBackColor = clrCard;
      qHeaderStyle.SelectionForeColor = clrSec;
      this.dgvQueue.ColumnHeadersDefaultCellStyle = qHeaderStyle;

      // Стиль ячеек по умолчанию
      var qCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
      qCellStyle.BackColor = clrBg;
      qCellStyle.ForeColor = clrPri;
      qCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
      qCellStyle.SelectionBackColor = clrSel;
      qCellStyle.SelectionForeColor = clrPri;
      qCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
      this.dgvQueue.DefaultCellStyle = qCellStyle;

      // Чётные строки — чуть темнее
      var qAltStyle = new System.Windows.Forms.DataGridViewCellStyle();
      qAltStyle.BackColor = clrRowAlt;
      qAltStyle.SelectionBackColor = clrSel;
      this.dgvQueue.AlternatingRowsDefaultCellStyle = qAltStyle;

      // colQFile — "File": имя + домен рисуются через CellPainting (две строки)
      // В Tag строки храни объект DownloadItem, откуда CellPainting берёт данные
      this.colQFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colQFile.FillWeight = 50F;
      this.colQFile.HeaderText = "File";
      this.colQFile.MinimumWidth = 180;
      this.colQFile.Name = "colQFile";
      this.colQFile.ReadOnly = true;
      this.colQFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

      // colQSize
      this.colQSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colQSize.HeaderText = "Size";
      this.colQSize.Name = "colQSize";
      this.colQSize.ReadOnly = true;
      this.colQSize.Width = 90;
      this.colQSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colQSize.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.colQSize.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
      this.colQSize.HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.colQSize.HeaderCell.Style.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);

      // colQProgress — рендерится как прогресс-бар через CellPainting в MainForm.cs
      // Значение ячейки: int 0–100 (процент); скорость — из Tag строки
      this.colQProgress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colQProgress.FillWeight = 28F;
      this.colQProgress.HeaderText = "Progress";
      this.colQProgress.MinimumWidth = 110;
      this.colQProgress.Name = "colQProgress";
      this.colQProgress.ReadOnly = true;
      this.colQProgress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colQProgress.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);

      // colQStatus — рендерится как цветной бейдж через CellPainting в MainForm.cs
      // Значение ячейки: строка "Downloading" / "Complete" / "Queued" / "Failed"
      this.colQStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colQStatus.HeaderText = "Status";
      this.colQStatus.Name = "colQStatus";
      this.colQStatus.ReadOnly = true;
      this.colQStatus.Width = 130;
      this.colQStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colQStatus.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.colQStatus.HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

      this.dgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
      {
                this.colQFile, this.colQSize, this.colQProgress, this.colQStatus
      });

      // ═══════════════════════════════════════════════════════════════════
      // dgvHistory — история загрузок с WCF-сервера
      // ═══════════════════════════════════════════════════════════════════
      this.dgvHistory.AllowUserToAddRows = false;
      this.dgvHistory.AllowUserToDeleteRows = false;
      this.dgvHistory.AllowUserToResizeRows = false;
      this.dgvHistory.BackgroundColor = clrBg;
      this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.dgvHistory.ColumnHeadersVisible = false;   // заголовки скрыты — секция делит с очередью
      this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvHistory.EnableHeadersVisualStyles = false;
      this.dgvHistory.GridColor = clrBorder;
      this.dgvHistory.MultiSelect = false;
      this.dgvHistory.Name = "dgvHistory";
      this.dgvHistory.ReadOnly = true;
      this.dgvHistory.RowHeadersVisible = false;
      this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvHistory.ShowCellToolTips = false;
      this.dgvHistory.RowTemplate.Height = 56;
      this.dgvHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

      var hCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
      hCellStyle.BackColor = clrBg;
      hCellStyle.ForeColor = clrPri;
      hCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
      hCellStyle.SelectionBackColor = clrSel;
      hCellStyle.SelectionForeColor = clrPri;
      hCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
      this.dgvHistory.DefaultCellStyle = hCellStyle;

      var hAltStyle = new System.Windows.Forms.DataGridViewCellStyle();
      hAltStyle.BackColor = clrRowAlt;
      hAltStyle.SelectionBackColor = clrSel;
      this.dgvHistory.AlternatingRowsDefaultCellStyle = hAltStyle;

      // colHFile — имя файла + дата сохранения (двустрочный CellPainting)
      this.colHFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colHFile.FillWeight = 60F;
      this.colHFile.HeaderText = "File";
      this.colHFile.MinimumWidth = 180;
      this.colHFile.Name = "colHFile";
      this.colHFile.ReadOnly = true;
      this.colHFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

      // colHSize
      this.colHSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colHSize.HeaderText = "Size";
      this.colHSize.Name = "colHSize";
      this.colHSize.ReadOnly = true;
      this.colHSize.Width = 90;
      this.colHSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colHSize.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.colHSize.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);

      // colHStatus — бейдж "Logged" (зелёный), рисуется через CellPainting
      this.colHStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colHStatus.HeaderText = "Status";
      this.colHStatus.Name = "colHStatus";
      this.colHStatus.ReadOnly = true;
      this.colHStatus.Width = 130;
      this.colHStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colHStatus.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

      this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
      {
                this.colHFile, this.colHSize, this.colHStatus
      });

      // ═══════════════════════════════════════════════════════════════════
      // statusStrip — нижняя строка состояния
      // ═══════════════════════════════════════════════════════════════════
      this.statusStrip.BackColor = clrCard;
      this.statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 8.5F);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.SizingGrip = false;
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
      {
                this.tsslActive,
                this.tssSep1,
                this.tsslTotalDownloaded,
                this.tssSep2,
                this.tsslWcfLabel,
                this.tsslWcfStatus,
                this.tssSep3,
                this.tsslDb
      });

      this.tsslActive.ForeColor = clrSec;
      this.tsslActive.Name = "tsslActive";
      this.tsslActive.Text = "0 active";

      this.tssSep1.Name = "tssSep1";

      this.tsslTotalDownloaded.ForeColor = clrSec;
      this.tsslTotalDownloaded.Name = "tsslTotalDownloaded";
      this.tsslTotalDownloaded.Text = "Total downloaded: 0 B";

      this.tssSep2.Name = "tssSep2";

      this.tsslWcfLabel.ForeColor = clrSec;
      this.tsslWcfLabel.Name = "tsslWcfLabel";
      this.tsslWcfLabel.Text = "WCF service:";

      // tsslWcfStatus обновляется из кода: ForeColor = clrGreen при успехе
      this.tsslWcfStatus.ForeColor = clrRed;
      this.tsslWcfStatus.Name = "tsslWcfStatus";
      this.tsslWcfStatus.Text = "disconnected";

      this.tssSep3.Name = "tssSep3";

      this.tsslDb.ForeColor = clrSec;
      this.tsslDb.Name = "tsslDb";
      this.tsslDb.Text = "DB: downloads.db";

      // ═══════════════════════════════════════════════════════════════════
      // Настройки формы
      // ═══════════════════════════════════════════════════════════════════
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.BackColor = clrBg;
      this.ClientSize = new System.Drawing.Size(980, 700);
      this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
      this.ForeColor = clrPri;
      this.MinimumSize = new System.Drawing.Size(780, 560);
      this.Name = "MainForm";
      this.Text = "File Downloader";

      // Порядок Controls.Add определяет раскладку Dock:
      // Layout обрабатывает контролы от последнего добавленного к первому.
      // ─ statusStrip добавляем ПОСЛЕДНИМ → обрабатывается ПЕРВЫМ → Dock=Bottom ✓
      // ─ pnlTop добавляем третьим → Dock=Top, верх формы ✓
      // ─ pnlStats добавляем вторым → Dock=Top, под pnlTop ✓
      // ─ tlpMain добавляем ПЕРВЫМ → обрабатывается ПОСЛЕДНИМ → Dock=Fill ✓
      this.Controls.Add(this.tlpMain);
      this.Controls.Add(this.pnlStats);
      this.Controls.Add(this.pnlTop);
      this.Controls.Add(this.statusStrip);

      // ── ResumeLayout ──────────────────────────────────────────────────
      this.pnlTop.ResumeLayout(false);

      this.pnlStatCompleted.ResumeLayout(false);
      this.pnlStatCompleted.PerformLayout();
      this.pnlStatDownloading.ResumeLayout(false);
      this.pnlStatDownloading.PerformLayout();
      this.pnlStatQueued.ResumeLayout(false);
      this.pnlStatQueued.PerformLayout();
      this.pnlStatFailed.ResumeLayout(false);
      this.pnlStatFailed.PerformLayout();
      this.tlpStats.ResumeLayout(false);
      this.pnlStats.ResumeLayout(false);

      this.pnlQueueHeader.ResumeLayout(false);
      this.pnlHistoryHeader.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)this.dgvQueue).EndInit();
      ((System.ComponentModel.ISupportInitialize)this.dgvHistory).EndInit();
      this.tlpMain.ResumeLayout(false);

      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    // ── Объявления полей ────────────────────────────────────────────────
    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.TextBox txtUrl;
    private System.Windows.Forms.Button btnAddUrl;
    private System.Windows.Forms.Button btnClearDone;
    private System.Windows.Forms.Button btnCancelAll;

    private System.Windows.Forms.Panel pnlStats;
    private System.Windows.Forms.TableLayoutPanel tlpStats;
    private System.Windows.Forms.Panel pnlStatCompleted;
    private System.Windows.Forms.Label lblCompletedNum;
    private System.Windows.Forms.Label lblCompletedText;
    private System.Windows.Forms.Panel pnlStatDownloading;
    private System.Windows.Forms.Label lblDownloadingNum;
    private System.Windows.Forms.Label lblDownloadingText;
    private System.Windows.Forms.Panel pnlStatQueued;
    private System.Windows.Forms.Label lblQueuedNum;
    private System.Windows.Forms.Label lblQueuedText;
    private System.Windows.Forms.Panel pnlStatFailed;
    private System.Windows.Forms.Label lblFailedNum;
    private System.Windows.Forms.Label lblFailedText;

    private System.Windows.Forms.TableLayoutPanel tlpMain;
    private System.Windows.Forms.Panel pnlQueueHeader;
    private System.Windows.Forms.Label lblQueueHeader;
    private System.Windows.Forms.DataGridView dgvQueue;
    private System.Windows.Forms.DataGridViewTextBoxColumn colQFile;
    private System.Windows.Forms.DataGridViewTextBoxColumn colQSize;
    private System.Windows.Forms.DataGridViewTextBoxColumn colQProgress;
    private System.Windows.Forms.DataGridViewTextBoxColumn colQStatus;

    private System.Windows.Forms.Panel pnlHistoryHeader;
    private System.Windows.Forms.Label lblHistoryHeader;
    private System.Windows.Forms.DataGridView dgvHistory;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHFile;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHSize;
    private System.Windows.Forms.DataGridViewTextBoxColumn colHStatus;

    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel tsslActive;
    private System.Windows.Forms.ToolStripSeparator tssSep1;
    private System.Windows.Forms.ToolStripStatusLabel tsslTotalDownloaded;
    private System.Windows.Forms.ToolStripSeparator tssSep2;
    private System.Windows.Forms.ToolStripStatusLabel tsslWcfLabel;
    private System.Windows.Forms.ToolStripStatusLabel tsslWcfStatus;
    private System.Windows.Forms.ToolStripSeparator tssSep3;
    private System.Windows.Forms.ToolStripStatusLabel tsslDb;
  }
}
