﻿namespace vSongBook
{
    partial class DdSongEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DdSongEdit));
            this.tblRight = new System.Windows.Forms.TableLayoutPanel();
            this.tblTop = new System.Windows.Forms.TableLayoutPanel();
            this.txtSongKey = new JacksiroCtrl.JsTextBox();
            this.btnSaveOnly = new JacksiroCtrl.JsButton();
            this.btnSaveClose = new JacksiroCtrl.JsButton();
            this.lblSongNo = new System.Windows.Forms.Label();
            this.txtNumber = new JacksiroCtrl.JsTextBox();
            this.grpSongContent = new System.Windows.Forms.GroupBox();
            this.txtSongContent = new System.Windows.Forms.TextBox();
            this.lstBookcodes = new System.Windows.Forms.ListBox();
            this.tblExtra = new System.Windows.Forms.TableLayoutPanel();
            this.ToolStripSong = new System.Windows.Forms.ToolStrip();
            this.tsbtnLast = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.txtSongTitle = new JacksiroCtrl.JsTextBox();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.grpSongResults = new System.Windows.Forms.GroupBox();
            this.lstSongResults = new System.Windows.Forms.ListBox();
            this.jsFeedback = new JacksiroCtrl.JsFeedback();
            this.tblRight.SuspendLayout();
            this.tblTop.SuspendLayout();
            this.grpSongContent.SuspendLayout();
            this.tblExtra.SuspendLayout();
            this.ToolStripSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tblLeft.SuspendLayout();
            this.grpSongResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblRight
            // 
            this.tblRight.ColumnCount = 1;
            this.tblRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRight.Controls.Add(this.tblTop, 0, 0);
            this.tblRight.Controls.Add(this.grpSongContent, 0, 2);
            this.tblRight.Controls.Add(this.tblExtra, 0, 1);
            this.tblRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRight.Location = new System.Drawing.Point(0, 0);
            this.tblRight.Margin = new System.Windows.Forms.Padding(0);
            this.tblRight.Name = "tblRight";
            this.tblRight.RowCount = 4;
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblRight.Size = new System.Drawing.Size(485, 366);
            this.tblRight.TabIndex = 0;
            // 
            // tblTop
            // 
            this.tblTop.ColumnCount = 5;
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTop.Controls.Add(this.txtSongKey, 2, 0);
            this.tblTop.Controls.Add(this.btnSaveOnly, 4, 0);
            this.tblTop.Controls.Add(this.btnSaveClose, 3, 0);
            this.tblTop.Controls.Add(this.lblSongNo, 0, 0);
            this.tblTop.Controls.Add(this.txtNumber, 1, 0);
            this.tblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTop.Location = new System.Drawing.Point(3, 3);
            this.tblTop.Name = "tblTop";
            this.tblTop.RowCount = 1;
            this.tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTop.Size = new System.Drawing.Size(479, 34);
            this.tblTop.TabIndex = 0;
            // 
            // txtSongKey
            // 
            this.txtSongKey.BackColor = System.Drawing.Color.Transparent;
            this.txtSongKey.Background = System.Drawing.Color.White;
            this.txtSongKey.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongKey.ForeColor = System.Drawing.Color.Black;
            this.txtSongKey.IsSearch = false;
            this.txtSongKey.Location = new System.Drawing.Point(170, 0);
            this.txtSongKey.Margin = new System.Windows.Forms.Padding(0);
            this.txtSongKey.Name = "txtSongKey";
            this.txtSongKey.Placeholder = "KEY";
            this.txtSongKey.ShowIcon = false;
            this.txtSongKey.Size = new System.Drawing.Size(80, 34);
            this.txtSongKey.TabIndex = 10;
            this.txtSongKey.Text = "KEY";
            // 
            // btnSaveOnly
            // 
            this.btnSaveOnly.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveOnly.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSaveOnly.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveOnly.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveOnly.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveOnly.ForeColor = System.Drawing.Color.Black;
            this.btnSaveOnly.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveOnly.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveOnly.Location = new System.Drawing.Point(367, 3);
            this.btnSaveOnly.Name = "btnSaveOnly";
            this.btnSaveOnly.Radius = 5;
            this.btnSaveOnly.Size = new System.Drawing.Size(109, 30);
            this.btnSaveOnly.Stroke = true;
            this.btnSaveOnly.StrokeColor = System.Drawing.Color.Black;
            this.btnSaveOnly.TabIndex = 9;
            this.btnSaveOnly.Text = "Save ONLY";
            this.btnSaveOnly.Transparency = false;
            this.btnSaveOnly.Click += new System.EventHandler(this.btnSaveOnly_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveClose.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSaveClose.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveClose.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveClose.ForeColor = System.Drawing.Color.Black;
            this.btnSaveClose.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveClose.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveClose.Location = new System.Drawing.Point(253, 3);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Radius = 5;
            this.btnSaveClose.Size = new System.Drawing.Size(108, 30);
            this.btnSaveClose.Stroke = true;
            this.btnSaveClose.StrokeColor = System.Drawing.Color.Black;
            this.btnSaveClose.TabIndex = 8;
            this.btnSaveClose.Text = "Save and CLOSE";
            this.btnSaveClose.Transparency = false;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // lblSongNo
            // 
            this.lblSongNo.AutoSize = true;
            this.lblSongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSongNo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongNo.Location = new System.Drawing.Point(3, 0);
            this.lblSongNo.Name = "lblSongNo";
            this.lblSongNo.Size = new System.Drawing.Size(84, 36);
            this.lblSongNo.TabIndex = 0;
            this.lblSongNo.Text = "Song NO:";
            this.lblSongNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtNumber.Background = System.Drawing.Color.White;
            this.txtNumber.Enabled = false;
            this.txtNumber.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.Black;
            this.txtNumber.IsSearch = false;
            this.txtNumber.Location = new System.Drawing.Point(90, 0);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Placeholder = "#";
            this.txtNumber.ShowIcon = false;
            this.txtNumber.Size = new System.Drawing.Size(69, 34);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.Text = "#";
            // 
            // grpSongContent
            // 
            this.grpSongContent.Controls.Add(this.txtSongContent);
            this.grpSongContent.Controls.Add(this.lstBookcodes);
            this.grpSongContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSongContent.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSongContent.Location = new System.Drawing.Point(3, 78);
            this.grpSongContent.Name = "grpSongContent";
            this.grpSongContent.Padding = new System.Windows.Forms.Padding(10);
            this.grpSongContent.Size = new System.Drawing.Size(479, 265);
            this.grpSongContent.TabIndex = 12;
            this.grpSongContent.TabStop = false;
            this.grpSongContent.Text = " Song content goes here: ";
            // 
            // txtSongContent
            // 
            this.txtSongContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSongContent.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongContent.Location = new System.Drawing.Point(10, 29);
            this.txtSongContent.Margin = new System.Windows.Forms.Padding(10);
            this.txtSongContent.Multiline = true;
            this.txtSongContent.Name = "txtSongContent";
            this.txtSongContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSongContent.Size = new System.Drawing.Size(459, 226);
            this.txtSongContent.TabIndex = 13;
            // 
            // lstBookcodes
            // 
            this.lstBookcodes.FormattingEnabled = true;
            this.lstBookcodes.ItemHeight = 22;
            this.lstBookcodes.Location = new System.Drawing.Point(140, 43);
            this.lstBookcodes.Name = "lstBookcodes";
            this.lstBookcodes.Size = new System.Drawing.Size(144, 158);
            this.lstBookcodes.TabIndex = 0;
            this.lstBookcodes.SelectedIndexChanged += new System.EventHandler(this.lstBookcodes_SelectedIndexChanged);
            // 
            // tblExtra
            // 
            this.tblExtra.ColumnCount = 2;
            this.tblExtra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblExtra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblExtra.Controls.Add(this.ToolStripSong, 1, 0);
            this.tblExtra.Controls.Add(this.txtSongTitle, 0, 0);
            this.tblExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblExtra.Location = new System.Drawing.Point(3, 43);
            this.tblExtra.Name = "tblExtra";
            this.tblExtra.RowCount = 1;
            this.tblExtra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblExtra.Size = new System.Drawing.Size(479, 29);
            this.tblExtra.TabIndex = 13;
            // 
            // ToolStripSong
            // 
            this.ToolStripSong.AutoSize = false;
            this.ToolStripSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripSong.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripSong.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripSong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLast,
            this.tsbtnNext});
            this.ToolStripSong.Location = new System.Drawing.Point(379, 0);
            this.ToolStripSong.Name = "ToolStripSong";
            this.ToolStripSong.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.ToolStripSong.Size = new System.Drawing.Size(100, 29);
            this.ToolStripSong.Stretch = true;
            this.ToolStripSong.TabIndex = 12;
            // 
            // tsbtnLast
            // 
            this.tsbtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLast.Image")));
            this.tsbtnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLast.Name = "tsbtnLast";
            this.tsbtnLast.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnLast.Size = new System.Drawing.Size(38, 26);
            this.tsbtnLast.Text = "&Last";
            this.tsbtnLast.ToolTipText = "Last song before current song";
            this.tsbtnLast.Click += new System.EventHandler(this.tsbtnLast_Click);
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNext.Image")));
            this.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnNext.Size = new System.Drawing.Size(38, 26);
            this.tsbtnNext.Text = "&Next";
            this.tsbtnNext.ToolTipText = "Next song after current song";
            this.tsbtnNext.Click += new System.EventHandler(this.tsbtnNext_Click);
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtSongTitle.Background = System.Drawing.Color.White;
            this.txtSongTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSongTitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongTitle.ForeColor = System.Drawing.Color.Black;
            this.txtSongTitle.IsSearch = false;
            this.txtSongTitle.Location = new System.Drawing.Point(0, 0);
            this.txtSongTitle.Margin = new System.Windows.Forms.Padding(0);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Placeholder = "Title of the Song";
            this.txtSongTitle.ShowIcon = false;
            this.txtSongTitle.Size = new System.Drawing.Size(379, 29);
            this.txtSongTitle.TabIndex = 11;
            this.txtSongTitle.Text = "Title of the Song";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.tblLeft);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tblRight);
            this.splitMain.Size = new System.Drawing.Size(739, 366);
            this.splitMain.SplitterDistance = 250;
            this.splitMain.TabIndex = 1;
            // 
            // tblLeft
            // 
            this.tblLeft.ColumnCount = 1;
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.Controls.Add(this.cmbBooks, 0, 0);
            this.tblLeft.Controls.Add(this.grpSongResults, 0, 1);
            this.tblLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeft.Location = new System.Drawing.Point(0, 0);
            this.tblLeft.Name = "tblLeft";
            this.tblLeft.RowCount = 2;
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.Size = new System.Drawing.Size(250, 366);
            this.tblLeft.TabIndex = 0;
            // 
            // cmbBooks
            // 
            this.cmbBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooks.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(3, 3);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(244, 35);
            this.cmbBooks.TabIndex = 0;
            this.cmbBooks.SelectedIndexChanged += new System.EventHandler(this.cmbBooks_SelectedIndexChanged);
            // 
            // grpSongResults
            // 
            this.grpSongResults.Controls.Add(this.lstSongResults);
            this.grpSongResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSongResults.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSongResults.Location = new System.Drawing.Point(3, 43);
            this.grpSongResults.Name = "grpSongResults";
            this.grpSongResults.Size = new System.Drawing.Size(244, 320);
            this.grpSongResults.TabIndex = 1;
            this.grpSongResults.TabStop = false;
            this.grpSongResults.Text = " 0 Songs for this Book: ";
            // 
            // lstSongResults
            // 
            this.lstSongResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSongResults.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongResults.FormattingEnabled = true;
            this.lstSongResults.ItemHeight = 22;
            this.lstSongResults.Location = new System.Drawing.Point(3, 19);
            this.lstSongResults.Name = "lstSongResults";
            this.lstSongResults.Size = new System.Drawing.Size(238, 298);
            this.lstSongResults.TabIndex = 0;
            // 
            // jsFeedback
            // 
            this.jsFeedback.BackColor = System.Drawing.Color.LightGreen;
            this.jsFeedback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jsFeedback.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.jsFeedback.ForeColor = System.Drawing.Color.Black;
            this.jsFeedback.Interval = 2500F;
            this.jsFeedback.IsPositive = true;
            this.jsFeedback.IsTimed = false;
            this.jsFeedback.Location = new System.Drawing.Point(0, 316);
            this.jsFeedback.Name = "jsFeedback";
            this.jsFeedback.Size = new System.Drawing.Size(739, 50);
            this.jsFeedback.TabIndex = 2;
            this.jsFeedback.Text = "vSongBook Feedback";
            this.jsFeedback.Visible = false;
            // 
            // DdSongEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 366);
            this.Controls.Add(this.jsFeedback);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DdSongEdit";
            this.Text = "Edit Song";
            this.Load += new System.EventHandler(this.DdSongEdit_Load);
            this.tblRight.ResumeLayout(false);
            this.tblTop.ResumeLayout(false);
            this.tblTop.PerformLayout();
            this.grpSongContent.ResumeLayout(false);
            this.grpSongContent.PerformLayout();
            this.tblExtra.ResumeLayout(false);
            this.ToolStripSong.ResumeLayout(false);
            this.ToolStripSong.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tblLeft.ResumeLayout(false);
            this.grpSongResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblRight;
        private System.Windows.Forms.TableLayoutPanel tblTop;
        private System.Windows.Forms.Label lblSongNo;
        private JacksiroCtrl.JsTextBox txtNumber;
        private JacksiroCtrl.JsTextBox txtSongTitle;
        private JacksiroCtrl.JsTextBox txtSongKey;
        private JacksiroCtrl.JsButton btnSaveOnly;
        private JacksiroCtrl.JsButton btnSaveClose;
        private System.Windows.Forms.TextBox txtSongContent;
        private System.Windows.Forms.GroupBox grpSongContent;
        private System.Windows.Forms.ListBox lstBookcodes;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TableLayoutPanel tblLeft;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.GroupBox grpSongResults;
        private System.Windows.Forms.ListBox lstSongResults;
        private JacksiroCtrl.JsFeedback jsFeedback;
        private System.Windows.Forms.TableLayoutPanel tblExtra;
        private System.Windows.Forms.ToolStrip ToolStripSong;
        private System.Windows.Forms.ToolStripButton tsbtnLast;
        private System.Windows.Forms.ToolStripButton tsbtnNext;

    }
}