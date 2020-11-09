﻿namespace BetterJoyForCemu {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.console = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version_lbl = new System.Windows.Forms.Label();
            this.passiveScanBox = new System.Windows.Forms.CheckBox();
            this.donationLink = new System.Windows.Forms.LinkLabel();
            this.conCntrls = new System.Windows.Forms.GroupBox();
            this.right4 = new System.Windows.Forms.CheckBox();
            this.right3 = new System.Windows.Forms.CheckBox();
            this.right2 = new System.Windows.Forms.CheckBox();
            this.right1 = new System.Windows.Forms.CheckBox();
            this.loc4 = new System.Windows.Forms.Button();
            this.loc3 = new System.Windows.Forms.Button();
            this.loc2 = new System.Windows.Forms.Button();
            this.loc1 = new System.Windows.Forms.Button();
            this.con4 = new System.Windows.Forms.Button();
            this.con3 = new System.Windows.Forms.Button();
            this.con2 = new System.Windows.Forms.Button();
            this.con1 = new System.Windows.Forms.Button();
            this.btnTip = new System.Windows.Forms.ToolTip(this.components);
            this.foldLbl = new System.Windows.Forms.Label();
            this.startInTrayBox = new System.Windows.Forms.CheckBox();
            this.btn_open3rdP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.settingsApply = new System.Windows.Forms.Button();
            this.AutoCalibrate = new System.Windows.Forms.Button();
            this.btn_reassign_open = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            this.conCntrls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(18, 215);
            this.console.Margin = new System.Windows.Forms.Padding(4);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(391, 105);
            this.console.TabIndex = 2;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Double click the tray icon to maximise!";
            this.notifyIcon.BalloonTipTitle = "BetterJoy";
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BetterJoy";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(112, 34);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // version_lbl
            // 
            this.version_lbl.AutoSize = true;
            this.version_lbl.Location = new System.Drawing.Point(369, 331);
            this.version_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(44, 18);
            this.version_lbl.TabIndex = 2;
            this.version_lbl.Text = "v6.4";
            // 
            // passiveScanBox
            // 
            this.passiveScanBox.AutoSize = true;
            this.passiveScanBox.Checked = true;
            this.passiveScanBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.passiveScanBox.Location = new System.Drawing.Point(18, 330);
            this.passiveScanBox.Margin = new System.Windows.Forms.Padding(4);
            this.passiveScanBox.Name = "passiveScanBox";
            this.passiveScanBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passiveScanBox.Size = new System.Drawing.Size(142, 22);
            this.passiveScanBox.TabIndex = 4;
            this.passiveScanBox.Text = "Passive Scan";
            this.passiveScanBox.UseVisualStyleBackColor = true;
            this.passiveScanBox.CheckedChanged += new System.EventHandler(this.passiveScanBox_CheckedChanged);
            // 
            // donationLink
            // 
            this.donationLink.AutoSize = true;
            this.donationLink.Location = new System.Drawing.Point(294, 331);
            this.donationLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.donationLink.Name = "donationLink";
            this.donationLink.Size = new System.Drawing.Size(62, 18);
            this.donationLink.TabIndex = 5;
            this.donationLink.TabStop = true;
            this.donationLink.Text = "Donate";
            this.donationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // conCntrls
            // 
            this.conCntrls.Controls.Add(this.right4);
            this.conCntrls.Controls.Add(this.right3);
            this.conCntrls.Controls.Add(this.right2);
            this.conCntrls.Controls.Add(this.right1);
            this.conCntrls.Controls.Add(this.loc4);
            this.conCntrls.Controls.Add(this.loc3);
            this.conCntrls.Controls.Add(this.loc2);
            this.conCntrls.Controls.Add(this.loc1);
            this.conCntrls.Controls.Add(this.con4);
            this.conCntrls.Controls.Add(this.con3);
            this.conCntrls.Controls.Add(this.con2);
            this.conCntrls.Controls.Add(this.con1);
            this.conCntrls.Location = new System.Drawing.Point(18, 17);
            this.conCntrls.Margin = new System.Windows.Forms.Padding(4);
            this.conCntrls.Name = "conCntrls";
            this.conCntrls.Padding = new System.Windows.Forms.Padding(4);
            this.conCntrls.Size = new System.Drawing.Size(395, 165);
            this.conCntrls.TabIndex = 0;
            this.conCntrls.TabStop = false;
            this.conCntrls.Text = "Connected Controllers";
            // 
            // right4
            // 
            this.right4.AutoSize = true;
            this.right4.Location = new System.Drawing.Point(298, 141);
            this.right4.Name = "right4";
            this.right4.Size = new System.Drawing.Size(79, 22);
            this.right4.TabIndex = 16;
            this.right4.Text = "right";
            this.right4.UseVisualStyleBackColor = true;
            this.right4.CheckedChanged += new System.EventHandler(this.right4_CheckedChanged);
            // 
            // right3
            // 
            this.right3.AutoSize = true;
            this.right3.Location = new System.Drawing.Point(202, 140);
            this.right3.Name = "right3";
            this.right3.Size = new System.Drawing.Size(79, 22);
            this.right3.TabIndex = 15;
            this.right3.Text = "right";
            this.right3.UseVisualStyleBackColor = true;
            this.right3.CheckedChanged += new System.EventHandler(this.right3_CheckedChanged);
            // 
            // right2
            // 
            this.right2.AutoSize = true;
            this.right2.Location = new System.Drawing.Point(106, 140);
            this.right2.Name = "right2";
            this.right2.Size = new System.Drawing.Size(79, 22);
            this.right2.TabIndex = 15;
            this.right2.Text = "right";
            this.right2.UseVisualStyleBackColor = true;
            this.right2.CheckedChanged += new System.EventHandler(this.right2_CheckedChanged);
            // 
            // right1
            // 
            this.right1.AutoSize = true;
            this.right1.Location = new System.Drawing.Point(10, 140);
            this.right1.Name = "right1";
            this.right1.Size = new System.Drawing.Size(79, 22);
            this.right1.TabIndex = 14;
            this.right1.Text = "right";
            this.right1.UseVisualStyleBackColor = true;
            this.right1.CheckedChanged += new System.EventHandler(this.right1_CheckedChanged);
            // 
            // loc4
            // 
            this.loc4.Location = new System.Drawing.Point(297, 111);
            this.loc4.Margin = new System.Windows.Forms.Padding(4);
            this.loc4.Name = "loc4";
            this.loc4.Size = new System.Drawing.Size(87, 28);
            this.loc4.TabIndex = 7;
            this.loc4.Text = "Locate";
            this.loc4.UseVisualStyleBackColor = true;
            // 
            // loc3
            // 
            this.loc3.Location = new System.Drawing.Point(201, 111);
            this.loc3.Margin = new System.Windows.Forms.Padding(4);
            this.loc3.Name = "loc3";
            this.loc3.Size = new System.Drawing.Size(87, 28);
            this.loc3.TabIndex = 6;
            this.loc3.Text = "Locate";
            this.loc3.UseVisualStyleBackColor = true;
            // 
            // loc2
            // 
            this.loc2.Location = new System.Drawing.Point(105, 111);
            this.loc2.Margin = new System.Windows.Forms.Padding(4);
            this.loc2.Name = "loc2";
            this.loc2.Size = new System.Drawing.Size(87, 28);
            this.loc2.TabIndex = 5;
            this.loc2.Text = "Locate";
            this.loc2.UseVisualStyleBackColor = true;
            // 
            // loc1
            // 
            this.loc1.Location = new System.Drawing.Point(9, 111);
            this.loc1.Margin = new System.Windows.Forms.Padding(4);
            this.loc1.Name = "loc1";
            this.loc1.Size = new System.Drawing.Size(87, 28);
            this.loc1.TabIndex = 4;
            this.loc1.Text = "Locate";
            this.loc1.UseVisualStyleBackColor = true;
            // 
            // con4
            // 
            this.con4.BackgroundImage = global::BetterJoyForCemu.Properties.Resources.cross;
            this.con4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.con4.Enabled = false;
            this.con4.Location = new System.Drawing.Point(297, 28);
            this.con4.Margin = new System.Windows.Forms.Padding(4);
            this.con4.Name = "con4";
            this.con4.Size = new System.Drawing.Size(87, 82);
            this.con4.TabIndex = 3;
            this.con4.TabStop = false;
            this.con4.UseVisualStyleBackColor = true;
            // 
            // con3
            // 
            this.con3.BackgroundImage = global::BetterJoyForCemu.Properties.Resources.cross;
            this.con3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.con3.Enabled = false;
            this.con3.Location = new System.Drawing.Point(201, 28);
            this.con3.Margin = new System.Windows.Forms.Padding(4);
            this.con3.Name = "con3";
            this.con3.Size = new System.Drawing.Size(87, 82);
            this.con3.TabIndex = 2;
            this.con3.TabStop = false;
            this.con3.UseVisualStyleBackColor = true;
            // 
            // con2
            // 
            this.con2.BackgroundImage = global::BetterJoyForCemu.Properties.Resources.cross;
            this.con2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.con2.Enabled = false;
            this.con2.Location = new System.Drawing.Point(105, 28);
            this.con2.Margin = new System.Windows.Forms.Padding(4);
            this.con2.Name = "con2";
            this.con2.Size = new System.Drawing.Size(87, 82);
            this.con2.TabIndex = 1;
            this.con2.TabStop = false;
            this.con2.UseVisualStyleBackColor = true;
            // 
            // con1
            // 
            this.con1.BackgroundImage = global::BetterJoyForCemu.Properties.Resources.cross;
            this.con1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.con1.Enabled = false;
            this.con1.Location = new System.Drawing.Point(9, 28);
            this.con1.Margin = new System.Windows.Forms.Padding(4);
            this.con1.Name = "con1";
            this.con1.Size = new System.Drawing.Size(87, 82);
            this.con1.TabIndex = 0;
            this.con1.TabStop = false;
            this.btnTip.SetToolTip(this.con1, "Click on Joycons to join/split them");
            this.con1.UseVisualStyleBackColor = true;
            // 
            // foldLbl
            // 
            this.foldLbl.Location = new System.Drawing.Point(411, 28);
            this.foldLbl.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.foldLbl.Name = "foldLbl";
            this.foldLbl.Size = new System.Drawing.Size(20, 320);
            this.foldLbl.TabIndex = 12;
            this.foldLbl.Text = ">";
            this.foldLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTip.SetToolTip(this.foldLbl, "Config");
            this.foldLbl.Click += new System.EventHandler(this.foldLbl_Click);
            // 
            // startInTrayBox
            // 
            this.startInTrayBox.AutoSize = true;
            this.startInTrayBox.Location = new System.Drawing.Point(160, 330);
            this.startInTrayBox.Margin = new System.Windows.Forms.Padding(4);
            this.startInTrayBox.Name = "startInTrayBox";
            this.startInTrayBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startInTrayBox.Size = new System.Drawing.Size(151, 22);
            this.startInTrayBox.TabIndex = 6;
            this.startInTrayBox.Text = "Start in Tray";
            this.startInTrayBox.UseVisualStyleBackColor = true;
            this.startInTrayBox.CheckedChanged += new System.EventHandler(this.startInTrayBox_CheckedChanged);
            // 
            // btn_open3rdP
            // 
            this.btn_open3rdP.Location = new System.Drawing.Point(140, 180);
            this.btn_open3rdP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_open3rdP.Name = "btn_open3rdP";
            this.btn_open3rdP.Size = new System.Drawing.Size(129, 28);
            this.btn_open3rdP.TabIndex = 7;
            this.btn_open3rdP.Text = "Add Controllers";
            this.btn_open3rdP.UseVisualStyleBackColor = true;
            this.btn_open3rdP.Click += new System.EventHandler(this.btn_open3rdP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.settingsTable);
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 335);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // settingsTable
            // 
            this.settingsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTable.AutoScroll = true;
            this.settingsTable.ColumnCount = 2;
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.90411F));
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.09589F));
            this.settingsTable.Location = new System.Drawing.Point(6, 24);
            this.settingsTable.Name = "settingsTable";
            this.settingsTable.RowCount = 1;
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTable.Size = new System.Drawing.Size(450, 303);
            this.settingsTable.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.settingsApply);
            this.rightPanel.Controls.Add(this.groupBox1);
            this.rightPanel.Location = new System.Drawing.Point(434, 1);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(468, 378);
            this.rightPanel.TabIndex = 11;
            this.rightPanel.Visible = false;
            // 
            // settingsApply
            // 
            this.settingsApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsApply.Location = new System.Drawing.Point(369, 349);
            this.settingsApply.Name = "settingsApply";
            this.settingsApply.Size = new System.Drawing.Size(92, 29);
            this.settingsApply.TabIndex = 10;
            this.settingsApply.Text = "Apply";
            this.settingsApply.UseVisualStyleBackColor = true;
            this.settingsApply.Click += new System.EventHandler(this.settingsApply_Click);
            // 
            // AutoCalibrate
            // 
            this.AutoCalibrate.Location = new System.Drawing.Point(304, 179);
            this.AutoCalibrate.Margin = new System.Windows.Forms.Padding(4);
            this.AutoCalibrate.Name = "AutoCalibrate";
            this.AutoCalibrate.Size = new System.Drawing.Size(106, 28);
            this.AutoCalibrate.TabIndex = 8;
            this.AutoCalibrate.Text = "Calibrate";
            this.AutoCalibrate.UseVisualStyleBackColor = true;
            this.AutoCalibrate.Click += new System.EventHandler(this.StartCalibrate);
            // 
            // btn_reassign_open
            // 
            this.btn_reassign_open.Location = new System.Drawing.Point(18, 180);
            this.btn_reassign_open.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reassign_open.Name = "btn_reassign_open";
            this.btn_reassign_open.Size = new System.Drawing.Size(112, 28);
            this.btn_reassign_open.TabIndex = 13;
            this.btn_reassign_open.Text = "Map Buttons";
            this.btn_reassign_open.UseVisualStyleBackColor = true;
            this.btn_reassign_open.Click += new System.EventHandler(this.btn_reassign_open_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(922, 426);
            this.Controls.Add(this.btn_reassign_open);
            this.Controls.Add(this.foldLbl);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.AutoCalibrate);
            this.Controls.Add(this.btn_open3rdP);
            this.Controls.Add(this.startInTrayBox);
            this.Controls.Add(this.conCntrls);
            this.Controls.Add(this.donationLink);
            this.Controls.Add(this.passiveScanBox);
            this.Controls.Add(this.version_lbl);
            this.Controls.Add(this.console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BetterJoy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenu.ResumeLayout(false);
            this.conCntrls.ResumeLayout(false);
            this.conCntrls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox console;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label version_lbl;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox passiveScanBox;
        private System.Windows.Forms.LinkLabel donationLink;
        private System.Windows.Forms.GroupBox conCntrls;
        private System.Windows.Forms.Button con1;
        private System.Windows.Forms.Button con4;
        private System.Windows.Forms.Button con3;
        private System.Windows.Forms.Button con2;
        private System.Windows.Forms.Button loc4;
        private System.Windows.Forms.Button loc3;
        private System.Windows.Forms.Button loc2;
        private System.Windows.Forms.Button loc1;
        private System.Windows.Forms.ToolTip btnTip;
        private System.Windows.Forms.CheckBox startInTrayBox;
        private System.Windows.Forms.Button btn_open3rdP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel settingsTable;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button settingsApply;
        private System.Windows.Forms.Label foldLbl;
        private System.Windows.Forms.Button AutoCalibrate;
        private System.Windows.Forms.Button btn_reassign_open;
        private System.Windows.Forms.CheckBox right1;
        private System.Windows.Forms.CheckBox right4;
        private System.Windows.Forms.CheckBox right3;
        private System.Windows.Forms.CheckBox right2;
    }
}
