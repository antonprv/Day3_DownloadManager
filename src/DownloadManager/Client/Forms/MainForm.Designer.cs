// Created by Anton Piruev in 2026.
// Any direct commercial use of derivative work is strictly prohibited.

using System;
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlTop = new System.Windows.Forms.Panel();
      this.txtUrl = new System.Windows.Forms.TextBox();
      this.btnAddUrl = new System.Windows.Forms.Button();
      this.btnCancelAll = new System.Windows.Forms.Button();
      this.btnClearDone = new System.Windows.Forms.Button();
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
      this.pnlTop.SuspendLayout();
      this.pnlStats.SuspendLayout();
      this.tlpStats.SuspendLayout();
      this.pnlStatCompleted.SuspendLayout();
      this.pnlStatDownloading.SuspendLayout();
      this.pnlStatQueued.SuspendLayout();
      this.pnlStatFailed.SuspendLayout();
      this.tlpMain.SuspendLayout();
      this.pnlQueueHeader.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
      this.pnlHistoryHeader.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlTop
      // 
      this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      this.pnlTop.Controls.Add(this.txtUrl);
      this.pnlTop.Controls.Add(this.btnAddUrl);
      this.pnlTop.Controls.Add(this.btnCancelAll);
      this.pnlTop.Controls.Add(this.btnClearDone);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(1470, 108);
      this.pnlTop.TabIndex = 2;
      // 
      // txtUrl
      // 
      this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 10.5F);
      this.txtUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      this.txtUrl.Location = new System.Drawing.Point(13, 42);
      this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
      this.txtUrl.Name = "txtUrl";
      this.txtUrl.Size = new System.Drawing.Size(988, 35);
      this.txtUrl.TabIndex = 0;
      this.txtUrl.Text = "https://";
      // 
      // btnAddUrl
      // 
      this.btnAddUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
      this.btnAddUrl.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnAddUrl.FlatAppearance.BorderSize = 0;
      this.btnAddUrl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
      this.btnAddUrl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
      this.btnAddUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddUrl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
      this.btnAddUrl.ForeColor = System.Drawing.Color.White;
      this.btnAddUrl.Location = new System.Drawing.Point(1009, 36);
      this.btnAddUrl.Margin = new System.Windows.Forms.Padding(4);
      this.btnAddUrl.Name = "btnAddUrl";
      this.btnAddUrl.Size = new System.Drawing.Size(144, 48);
      this.btnAddUrl.TabIndex = 1;
      this.btnAddUrl.Text = "Add URL";
      this.btnAddUrl.UseVisualStyleBackColor = false;
      this.btnAddUrl.Click += new System.EventHandler(this.BtnAddUrl_ClickAsync);
      // 
      // btnCancelAll
      // 
      this.btnCancelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.btnCancelAll.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCancelAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(58)))));
      this.btnCancelAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
      this.btnCancelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelAll.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
      this.btnCancelAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(58)))));
      this.btnCancelAll.Location = new System.Drawing.Point(1313, 36);
      this.btnCancelAll.Margin = new System.Windows.Forms.Padding(4);
      this.btnCancelAll.Name = "btnCancelAll";
      this.btnCancelAll.Size = new System.Drawing.Size(144, 48);
      this.btnCancelAll.TabIndex = 3;
      this.btnCancelAll.Text = "Cancel all";
      this.btnCancelAll.UseVisualStyleBackColor = false;
      this.btnCancelAll.Click += new System.EventHandler(this.BtnCancelAll_Click);
      // 
      // btnClearDone
      // 
      this.btnClearDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClearDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.btnClearDone.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnClearDone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
      this.btnClearDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
      this.btnClearDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClearDone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
      this.btnClearDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      this.btnClearDone.Location = new System.Drawing.Point(1161, 36);
      this.btnClearDone.Margin = new System.Windows.Forms.Padding(4);
      this.btnClearDone.Name = "btnClearDone";
      this.btnClearDone.Size = new System.Drawing.Size(144, 48);
      this.btnClearDone.TabIndex = 2;
      this.btnClearDone.Text = "Clear done";
      this.btnClearDone.UseVisualStyleBackColor = false;
      this.btnClearDone.Click += new System.EventHandler(this.BtnClearDone_Click);
      // 
      // pnlStats
      // 
      this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      this.pnlStats.Controls.Add(this.tlpStats);
      this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlStats.Location = new System.Drawing.Point(0, 108);
      this.pnlStats.Margin = new System.Windows.Forms.Padding(4);
      this.pnlStats.Name = "pnlStats";
      this.pnlStats.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
      this.pnlStats.Size = new System.Drawing.Size(1470, 138);
      this.pnlStats.TabIndex = 1;
      // 
      // tlpStats
      // 
      this.tlpStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      this.tlpStats.ColumnCount = 4;
      this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tlpStats.Controls.Add(this.pnlStatCompleted, 0, 0);
      this.tlpStats.Controls.Add(this.pnlStatDownloading, 1, 0);
      this.tlpStats.Controls.Add(this.pnlStatQueued, 2, 0);
      this.tlpStats.Controls.Add(this.pnlStatFailed, 3, 0);
      this.tlpStats.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpStats.Location = new System.Drawing.Point(12, 9);
      this.tlpStats.Margin = new System.Windows.Forms.Padding(4);
      this.tlpStats.Name = "tlpStats";
      this.tlpStats.RowCount = 1;
      this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpStats.Size = new System.Drawing.Size(1446, 120);
      this.tlpStats.TabIndex = 0;
      // 
      // pnlStatCompleted
      // 
      this.pnlStatCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.pnlStatCompleted.Controls.Add(this.lblCompletedNum);
      this.pnlStatCompleted.Controls.Add(this.lblCompletedText);
      this.pnlStatCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlStatCompleted.Location = new System.Drawing.Point(0, 0);
      this.pnlStatCompleted.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
      this.pnlStatCompleted.Name = "pnlStatCompleted";
      this.pnlStatCompleted.Size = new System.Drawing.Size(353, 120);
      this.pnlStatCompleted.TabIndex = 0;
      // 
      // lblCompletedNum
      // 
      this.lblCompletedNum.AutoSize = true;
      this.lblCompletedNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
      this.lblCompletedNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      this.lblCompletedNum.Location = new System.Drawing.Point(24, 12);
      this.lblCompletedNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblCompletedNum.Name = "lblCompletedNum";
      this.lblCompletedNum.Size = new System.Drawing.Size(50, 60);
      this.lblCompletedNum.TabIndex = 0;
      this.lblCompletedNum.Text = "0";
      // 
      // lblCompletedText
      // 
      this.lblCompletedText.AutoSize = true;
      this.lblCompletedText.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblCompletedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.lblCompletedText.Location = new System.Drawing.Point(24, 69);
      this.lblCompletedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblCompletedText.Name = "lblCompletedText";
      this.lblCompletedText.Size = new System.Drawing.Size(100, 25);
      this.lblCompletedText.TabIndex = 1;
      this.lblCompletedText.Text = "Completed";
      // 
      // pnlStatDownloading
      // 
      this.pnlStatDownloading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.pnlStatDownloading.Controls.Add(this.lblDownloadingNum);
      this.pnlStatDownloading.Controls.Add(this.lblDownloadingText);
      this.pnlStatDownloading.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlStatDownloading.Location = new System.Drawing.Point(365, 0);
      this.pnlStatDownloading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.pnlStatDownloading.Name = "pnlStatDownloading";
      this.pnlStatDownloading.Size = new System.Drawing.Size(353, 120);
      this.pnlStatDownloading.TabIndex = 1;
      // 
      // lblDownloadingNum
      // 
      this.lblDownloadingNum.AutoSize = true;
      this.lblDownloadingNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
      this.lblDownloadingNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      this.lblDownloadingNum.Location = new System.Drawing.Point(24, 12);
      this.lblDownloadingNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblDownloadingNum.Name = "lblDownloadingNum";
      this.lblDownloadingNum.Size = new System.Drawing.Size(50, 60);
      this.lblDownloadingNum.TabIndex = 0;
      this.lblDownloadingNum.Text = "0";
      // 
      // lblDownloadingText
      // 
      this.lblDownloadingText.AutoSize = true;
      this.lblDownloadingText.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblDownloadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.lblDownloadingText.Location = new System.Drawing.Point(24, 69);
      this.lblDownloadingText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblDownloadingText.Name = "lblDownloadingText";
      this.lblDownloadingText.Size = new System.Drawing.Size(119, 25);
      this.lblDownloadingText.TabIndex = 1;
      this.lblDownloadingText.Text = "Downloading";
      // 
      // pnlStatQueued
      // 
      this.pnlStatQueued.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.pnlStatQueued.Controls.Add(this.lblQueuedNum);
      this.pnlStatQueued.Controls.Add(this.lblQueuedText);
      this.pnlStatQueued.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlStatQueued.Location = new System.Drawing.Point(726, 0);
      this.pnlStatQueued.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.pnlStatQueued.Name = "pnlStatQueued";
      this.pnlStatQueued.Size = new System.Drawing.Size(353, 120);
      this.pnlStatQueued.TabIndex = 2;
      // 
      // lblQueuedNum
      // 
      this.lblQueuedNum.AutoSize = true;
      this.lblQueuedNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
      this.lblQueuedNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      this.lblQueuedNum.Location = new System.Drawing.Point(24, 12);
      this.lblQueuedNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblQueuedNum.Name = "lblQueuedNum";
      this.lblQueuedNum.Size = new System.Drawing.Size(50, 60);
      this.lblQueuedNum.TabIndex = 0;
      this.lblQueuedNum.Text = "0";
      // 
      // lblQueuedText
      // 
      this.lblQueuedText.AutoSize = true;
      this.lblQueuedText.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblQueuedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.lblQueuedText.Location = new System.Drawing.Point(24, 69);
      this.lblQueuedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblQueuedText.Name = "lblQueuedText";
      this.lblQueuedText.Size = new System.Drawing.Size(75, 25);
      this.lblQueuedText.TabIndex = 1;
      this.lblQueuedText.Text = "Queued";
      // 
      // pnlStatFailed
      // 
      this.pnlStatFailed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.pnlStatFailed.Controls.Add(this.lblFailedNum);
      this.pnlStatFailed.Controls.Add(this.lblFailedText);
      this.pnlStatFailed.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlStatFailed.Location = new System.Drawing.Point(1091, 0);
      this.pnlStatFailed.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
      this.pnlStatFailed.Name = "pnlStatFailed";
      this.pnlStatFailed.Size = new System.Drawing.Size(355, 120);
      this.pnlStatFailed.TabIndex = 3;
      // 
      // lblFailedNum
      // 
      this.lblFailedNum.AutoSize = true;
      this.lblFailedNum.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
      this.lblFailedNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(58)))));
      this.lblFailedNum.Location = new System.Drawing.Point(24, 12);
      this.lblFailedNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblFailedNum.Name = "lblFailedNum";
      this.lblFailedNum.Size = new System.Drawing.Size(50, 60);
      this.lblFailedNum.TabIndex = 0;
      this.lblFailedNum.Text = "0";
      // 
      // lblFailedText
      // 
      this.lblFailedText.AutoSize = true;
      this.lblFailedText.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.lblFailedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.lblFailedText.Location = new System.Drawing.Point(24, 69);
      this.lblFailedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblFailedText.Name = "lblFailedText";
      this.lblFailedText.Size = new System.Drawing.Size(57, 25);
      this.lblFailedText.TabIndex = 1;
      this.lblFailedText.Text = "Failed";
      // 
      // tlpMain
      // 
      this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      this.tlpMain.ColumnCount = 1;
      this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpMain.Controls.Add(this.pnlQueueHeader, 0, 0);
      this.tlpMain.Controls.Add(this.dgvQueue, 0, 1);
      this.tlpMain.Controls.Add(this.pnlHistoryHeader, 0, 2);
      this.tlpMain.Controls.Add(this.dgvHistory, 0, 3);
      this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpMain.Location = new System.Drawing.Point(0, 246);
      this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
      this.tlpMain.Name = "tlpMain";
      this.tlpMain.RowCount = 4;
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
      this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
      this.tlpMain.Size = new System.Drawing.Size(1470, 774);
      this.tlpMain.TabIndex = 0;
      // 
      // pnlQueueHeader
      // 
      this.pnlQueueHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      this.pnlQueueHeader.Controls.Add(this.lblQueueHeader);
      this.pnlQueueHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlQueueHeader.Location = new System.Drawing.Point(4, 4);
      this.pnlQueueHeader.Margin = new System.Windows.Forms.Padding(4);
      this.pnlQueueHeader.Name = "pnlQueueHeader";
      this.pnlQueueHeader.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
      this.pnlQueueHeader.Size = new System.Drawing.Size(1462, 46);
      this.pnlQueueHeader.TabIndex = 0;
      // 
      // lblQueueHeader
      // 
      this.lblQueueHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
      this.lblQueueHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.lblQueueHeader.Location = new System.Drawing.Point(21, 0);
      this.lblQueueHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblQueueHeader.Name = "lblQueueHeader";
      this.lblQueueHeader.Size = new System.Drawing.Size(1433, 46);
      this.lblQueueHeader.TabIndex = 0;
      this.lblQueueHeader.Text = "DOWNLOAD QUEUE";
      this.lblQueueHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // dgvQueue
      // 
      this.dgvQueue.AllowUserToAddRows = false;
      this.dgvQueue.AllowUserToDeleteRows = false;
      this.dgvQueue.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
      this.dgvQueue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvQueue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      this.dgvQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.dgvQueue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.dgvQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvQueue.ColumnHeadersHeight = 36;
      this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQFile,
            this.colQSize,
            this.colQProgress,
            this.colQStatus});
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
      dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvQueue.DefaultCellStyle = dataGridViewCellStyle6;
      this.dgvQueue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvQueue.EnableHeadersVisualStyles = false;
      this.dgvQueue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
      this.dgvQueue.Location = new System.Drawing.Point(4, 58);
      this.dgvQueue.Margin = new System.Windows.Forms.Padding(4);
      this.dgvQueue.MultiSelect = false;
      this.dgvQueue.Name = "dgvQueue";
      this.dgvQueue.ReadOnly = true;
      this.dgvQueue.RowHeadersVisible = false;
      this.dgvQueue.RowHeadersWidth = 62;
      this.dgvQueue.RowTemplate.Height = 56;
      this.dgvQueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvQueue.ShowCellToolTips = false;
      this.dgvQueue.Size = new System.Drawing.Size(1462, 371);
      this.dgvQueue.TabIndex = 1;
      // 
      // colQFile
      // 
      this.colQFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colQFile.FillWeight = 50F;
      this.colQFile.HeaderText = "File";
      this.colQFile.MinimumWidth = 180;
      this.colQFile.Name = "colQFile";
      this.colQFile.ReadOnly = true;
      this.colQFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // colQSize
      // 
      this.colQSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
      this.colQSize.DefaultCellStyle = dataGridViewCellStyle3;
      this.colQSize.HeaderText = "Size";
      this.colQSize.MinimumWidth = 8;
      this.colQSize.Name = "colQSize";
      this.colQSize.ReadOnly = true;
      this.colQSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colQSize.Width = 90;
      // 
      // colQProgress
      // 
      this.colQProgress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
      this.colQProgress.DefaultCellStyle = dataGridViewCellStyle4;
      this.colQProgress.FillWeight = 28F;
      this.colQProgress.HeaderText = "Progress";
      this.colQProgress.MinimumWidth = 110;
      this.colQProgress.Name = "colQProgress";
      this.colQProgress.ReadOnly = true;
      this.colQProgress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // colQStatus
      // 
      this.colQStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.colQStatus.DefaultCellStyle = dataGridViewCellStyle5;
      this.colQStatus.HeaderText = "Status";
      this.colQStatus.MinimumWidth = 8;
      this.colQStatus.Name = "colQStatus";
      this.colQStatus.ReadOnly = true;
      this.colQStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colQStatus.Width = 150;
      // 
      // pnlHistoryHeader
      // 
      this.pnlHistoryHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      this.pnlHistoryHeader.Controls.Add(this.lblHistoryHeader);
      this.pnlHistoryHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlHistoryHeader.Location = new System.Drawing.Point(4, 437);
      this.pnlHistoryHeader.Margin = new System.Windows.Forms.Padding(4);
      this.pnlHistoryHeader.Name = "pnlHistoryHeader";
      this.pnlHistoryHeader.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
      this.pnlHistoryHeader.Size = new System.Drawing.Size(1462, 46);
      this.pnlHistoryHeader.TabIndex = 2;
      // 
      // lblHistoryHeader
      // 
      this.lblHistoryHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblHistoryHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
      this.lblHistoryHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.lblHistoryHeader.Location = new System.Drawing.Point(21, 0);
      this.lblHistoryHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblHistoryHeader.Name = "lblHistoryHeader";
      this.lblHistoryHeader.Size = new System.Drawing.Size(1441, 46);
      this.lblHistoryHeader.TabIndex = 0;
      this.lblHistoryHeader.Text = "HISTORY (FROM SERVER DB)";
      this.lblHistoryHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // dgvHistory
      // 
      this.dgvHistory.AllowUserToAddRows = false;
      this.dgvHistory.AllowUserToDeleteRows = false;
      this.dgvHistory.AllowUserToResizeRows = false;
      dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
      this.dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
      this.dgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.dgvHistory.ColumnHeadersHeight = 34;
      this.dgvHistory.ColumnHeadersVisible = false;
      this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHFile,
            this.colHSize,
            this.colHStatus});
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.5F);
      dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle10;
      this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvHistory.EnableHeadersVisualStyles = false;
      this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
      this.dgvHistory.Location = new System.Drawing.Point(4, 491);
      this.dgvHistory.Margin = new System.Windows.Forms.Padding(4);
      this.dgvHistory.MultiSelect = false;
      this.dgvHistory.Name = "dgvHistory";
      this.dgvHistory.ReadOnly = true;
      this.dgvHistory.RowHeadersVisible = false;
      this.dgvHistory.RowHeadersWidth = 62;
      this.dgvHistory.RowTemplate.Height = 56;
      this.dgvHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvHistory.ShowCellToolTips = false;
      this.dgvHistory.Size = new System.Drawing.Size(1462, 279);
      this.dgvHistory.TabIndex = 3;
      this.dgvHistory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvHistory_CellMouseRightClick);
      // 
      // colHFile
      // 
      this.colHFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colHFile.FillWeight = 60F;
      this.colHFile.HeaderText = "File";
      this.colHFile.MinimumWidth = 180;
      this.colHFile.Name = "colHFile";
      this.colHFile.ReadOnly = true;
      this.colHFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // colHSize
      // 
      this.colHSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
      this.colHSize.DefaultCellStyle = dataGridViewCellStyle8;
      this.colHSize.HeaderText = "Size";
      this.colHSize.MinimumWidth = 8;
      this.colHSize.Name = "colHSize";
      this.colHSize.ReadOnly = true;
      this.colHSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colHSize.Width = 90;
      // 
      // colHStatus
      // 
      this.colHStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.colHStatus.DefaultCellStyle = dataGridViewCellStyle9;
      this.colHStatus.HeaderText = "Status";
      this.colHStatus.MinimumWidth = 8;
      this.colHStatus.Name = "colHStatus";
      this.colHStatus.ReadOnly = true;
      this.colHStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.colHStatus.Width = 130;
      // 
      // statusStrip
      // 
      this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
      this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 8.5F);
      this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslActive,
            this.tssSep1,
            this.tsslTotalDownloaded,
            this.tssSep2,
            this.tsslWcfLabel,
            this.tsslWcfStatus,
            this.tssSep3,
            this.tsslDb});
      this.statusStrip.Location = new System.Drawing.Point(0, 1020);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
      this.statusStrip.Size = new System.Drawing.Size(1470, 30);
      this.statusStrip.SizingGrip = false;
      this.statusStrip.TabIndex = 3;
      // 
      // tsslActive
      // 
      this.tsslActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.tsslActive.Name = "tsslActive";
      this.tsslActive.Size = new System.Drawing.Size(68, 23);
      this.tsslActive.Text = "0 active";
      // 
      // tssSep1
      // 
      this.tssSep1.Name = "tssSep1";
      this.tssSep1.Size = new System.Drawing.Size(6, 30);
      // 
      // tsslTotalDownloaded
      // 
      this.tsslTotalDownloaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.tsslTotalDownloaded.Name = "tsslTotalDownloaded";
      this.tsslTotalDownloaded.Size = new System.Drawing.Size(178, 23);
      this.tsslTotalDownloaded.Text = "Total downloaded: 0 B";
      // 
      // tssSep2
      // 
      this.tssSep2.Name = "tssSep2";
      this.tssSep2.Size = new System.Drawing.Size(6, 30);
      // 
      // tsslWcfLabel
      // 
      this.tsslWcfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.tsslWcfLabel.Name = "tsslWcfLabel";
      this.tsslWcfLabel.Size = new System.Drawing.Size(105, 23);
      this.tsslWcfLabel.Text = "WCF service:";
      // 
      // tsslWcfStatus
      // 
      this.tsslWcfStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(58)))));
      this.tsslWcfStatus.Name = "tsslWcfStatus";
      this.tsslWcfStatus.Size = new System.Drawing.Size(111, 23);
      this.tsslWcfStatus.Text = "disconnected";
      // 
      // tssSep3
      // 
      this.tssSep3.Name = "tssSep3";
      this.tssSep3.Size = new System.Drawing.Size(6, 30);
      // 
      // tsslDb
      // 
      this.tsslDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
      this.tsslDb.Name = "tsslDb";
      this.tsslDb.Size = new System.Drawing.Size(147, 23);
      this.tsslDb.Text = "DB: downloads.db";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
      this.ClientSize = new System.Drawing.Size(1470, 1050);
      this.Controls.Add(this.tlpMain);
      this.Controls.Add(this.pnlStats);
      this.Controls.Add(this.pnlTop);
      this.Controls.Add(this.statusStrip);
      this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MinimumSize = new System.Drawing.Size(1159, 812);
      this.Name = "MainForm";
      this.Text = "File Downloader";
      this.pnlTop.ResumeLayout(false);
      this.pnlTop.PerformLayout();
      this.pnlStats.ResumeLayout(false);
      this.tlpStats.ResumeLayout(false);
      this.pnlStatCompleted.ResumeLayout(false);
      this.pnlStatCompleted.PerformLayout();
      this.pnlStatDownloading.ResumeLayout(false);
      this.pnlStatDownloading.PerformLayout();
      this.pnlStatQueued.ResumeLayout(false);
      this.pnlStatQueued.PerformLayout();
      this.pnlStatFailed.ResumeLayout(false);
      this.pnlStatFailed.PerformLayout();
      this.tlpMain.ResumeLayout(false);
      this.pnlQueueHeader.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
      this.pnlHistoryHeader.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    // - - - Field declarations - - -
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
