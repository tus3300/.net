namespace GUI.FRM
{
    partial class frmStaff
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnResetPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvStaff.Location = new System.Drawing.Point(7, 420);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowTemplate.Height = 28;
            this.dgvStaff.Size = new System.Drawing.Size(959, 262);
            this.dgvStaff.TabIndex = 3;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::GUI.Properties.Resources.open_box;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(802, 697);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 39);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::GUI.Properties.Resources.holding_wrench;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(640, 697);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 39);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::GUI.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(214, 697);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 39);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::GUI.Properties.Resources.add_file;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(23, 697);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(16, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(578, 35);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Tag = "Tên lớp";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(214, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 35);
            this.txtName.TabIndex = 9;
            this.txtName.Tag = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quyền";
            // 
            // cbbRole
            // 
            this.cbbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(214, 158);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(236, 37);
            this.cbbRole.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(705, 97);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(236, 35);
            this.txtPhone.TabIndex = 16;
            this.txtPhone.Tag = "Sô điện thoại";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(503, 94);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(190, 36);
            this.lb.TabIndex = 15;
            this.lb.Text = "Số điện thoại";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(214, 229);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(236, 35);
            this.txtNote.TabIndex = 18;
            this.txtNote.Tag = "Sô điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ghi chú";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(705, 163);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(236, 35);
            this.txtUsername.TabIndex = 20;
            this.txtUsername.Tag = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tài khoản";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quyền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tài khoản";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.AutoSize = true;
            this.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Image = global::GUI.Properties.Resources.drop_in_value;
            this.btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.Location = new System.Drawing.Point(369, 697);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(238, 39);
            this.btnResetPassword.TabIndex = 21;
            this.btnResetPassword.Text = "Reset mật khẩu";
            this.btnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 767);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStaff";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnResetPassword;
    }
}