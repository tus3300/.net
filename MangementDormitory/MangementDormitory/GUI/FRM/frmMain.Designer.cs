namespace GUI.FRM
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnClass = new System.Windows.Forms.ToolStripButton();
            this.btnRoom = new System.Windows.Forms.ToolStripButton();
            this.btnStaff = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStudent = new System.Windows.Forms.ToolStripButton();
            this.btnRentRoom = new System.Windows.Forms.ToolStripButton();
            this.btnStatistical = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelStaff = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(948, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassword,
            this.toolStripSeparator3,
            this.btnClose});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(98, 29);
            this.fileMenu.Text = "&Tài khoản";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnChangePassword.Size = new System.Drawing.Size(267, 30);
            this.btnChangePassword.Text = "&Đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(264, 6);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(267, 30);
            this.btnClose.Text = "&Thoát";
            this.btnClose.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClass,
            this.btnRoom,
            this.btnStaff,
            this.toolStripSeparator1,
            this.btnStudent,
            this.btnRentRoom,
            this.btnStatistical,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 35);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(138, 662);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // btnClass
            // 
            this.btnClass.Image = ((System.Drawing.Image)(resources.GetObject("btnClass.Image")));
            this.btnClass.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(133, 29);
            this.btnClass.Text = "Lớp";
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(133, 29);
            this.btnRoom.Text = "Phòng";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Image = global::GUI.Properties.Resources.bill;
            this.btnStaff.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(133, 29);
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // btnStudent
            // 
            this.btnStudent.Image = global::GUI.Properties.Resources.clipboard;
            this.btnStudent.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(133, 29);
            this.btnStudent.Text = "Học sinh";
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnRentRoom
            // 
            this.btnRentRoom.Image = global::GUI.Properties.Resources.devices;
            this.btnRentRoom.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRentRoom.Name = "btnRentRoom";
            this.btnRentRoom.Size = new System.Drawing.Size(133, 29);
            this.btnRentRoom.Text = "Thuê phòng";
            this.btnRentRoom.Click += new System.EventHandler(this.btnRentRoom_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistical.Image")));
            this.btnStatistical.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(133, 29);
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStaff});
            this.statusStrip.Location = new System.Drawing.Point(138, 667);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(810, 30);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // labelStaff
            // 
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(60, 25);
            this.labelStaff.Text = "Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Phần mềm quản lý kí túc xá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel labelStaff;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripButton btnClass;
        private System.Windows.Forms.ToolStripButton btnRoom;
        private System.Windows.Forms.ToolStripButton btnStaff;
        private System.Windows.Forms.ToolStripButton btnStudent;
        private System.Windows.Forms.ToolStripButton btnRentRoom;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton btnStatistical;
    }
}



