namespace GUI.FRM
{
    partial class frmRentRoom
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
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetContract = new System.Windows.Forms.Button();
            this.btnEditContract = new System.Windows.Forms.Button();
            this.btnDeleteContract = new System.Windows.Forms.Button();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.txtPriceActual = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesposit = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.cbbStudent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.AutoSize = true;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = global::GUI.Properties.Resources.add_file;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(676, 219);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(195, 39);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(642, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thuê phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetContract);
            this.groupBox1.Controls.Add(this.btnEditContract);
            this.groupBox1.Controls.Add(this.btnDeleteContract);
            this.groupBox1.Controls.Add(this.btnAddContract);
            this.groupBox1.Controls.Add(this.txtPriceActual);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDesposit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbRoom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateStart);
            this.groupBox1.Controls.Add(this.cbbStudent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvContract);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1483, 485);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hợp đồng";
            // 
            // btnResetContract
            // 
            this.btnResetContract.AutoSize = true;
            this.btnResetContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetContract.Image = global::GUI.Properties.Resources.open_box;
            this.btnResetContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetContract.Location = new System.Drawing.Point(1029, 419);
            this.btnResetContract.Name = "btnResetContract";
            this.btnResetContract.Size = new System.Drawing.Size(164, 39);
            this.btnResetContract.TabIndex = 10;
            this.btnResetContract.Text = "Làm mới";
            this.btnResetContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetContract.UseVisualStyleBackColor = true;
            this.btnResetContract.Click += new System.EventHandler(this.btnResetContract_Click);
            // 
            // btnEditContract
            // 
            this.btnEditContract.AutoSize = true;
            this.btnEditContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditContract.Image = global::GUI.Properties.Resources.holding_wrench;
            this.btnEditContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditContract.Location = new System.Drawing.Point(752, 419);
            this.btnEditContract.Name = "btnEditContract";
            this.btnEditContract.Size = new System.Drawing.Size(225, 39);
            this.btnEditContract.TabIndex = 9;
            this.btnEditContract.Text = "Sửa hợp đồng";
            this.btnEditContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditContract.UseVisualStyleBackColor = true;
            this.btnEditContract.Click += new System.EventHandler(this.btnEditContract_Click);
            // 
            // btnDeleteContract
            // 
            this.btnDeleteContract.AutoSize = true;
            this.btnDeleteContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContract.Image = global::GUI.Properties.Resources.delete;
            this.btnDeleteContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteContract.Location = new System.Drawing.Point(508, 419);
            this.btnDeleteContract.Name = "btnDeleteContract";
            this.btnDeleteContract.Size = new System.Drawing.Size(191, 39);
            this.btnDeleteContract.TabIndex = 9;
            this.btnDeleteContract.Text = "Trả phòng";
            this.btnDeleteContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteContract.UseVisualStyleBackColor = true;
            this.btnDeleteContract.Click += new System.EventHandler(this.btnDeleteContract_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.AutoSize = true;
            this.btnAddContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContract.Image = global::GUI.Properties.Resources.add_file;
            this.btnAddContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContract.Location = new System.Drawing.Point(220, 419);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(229, 39);
            this.btnAddContract.TabIndex = 9;
            this.btnAddContract.Text = "Tạo hợp đồng";
            this.btnAddContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // txtPriceActual
            // 
            this.txtPriceActual.Enabled = false;
            this.txtPriceActual.Location = new System.Drawing.Point(689, 96);
            this.txtPriceActual.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtPriceActual.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPriceActual.Name = "txtPriceActual";
            this.txtPriceActual.Size = new System.Drawing.Size(265, 35);
            this.txtPriceActual.TabIndex = 26;
            this.txtPriceActual.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 36);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giá thực tế";
            // 
            // txtDesposit
            // 
            this.txtDesposit.Location = new System.Drawing.Point(223, 92);
            this.txtDesposit.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtDesposit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDesposit.Name = "txtDesposit";
            this.txtDesposit.Size = new System.Drawing.Size(265, 35);
            this.txtDesposit.TabIndex = 24;
            this.txtDesposit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tiền đặt cọc";
            // 
            // cbbRoom
            // 
            this.cbbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(689, 34);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(265, 37);
            this.cbbRoom.TabIndex = 22;
            this.cbbRoom.SelectedValueChanged += new System.EventHandler(this.cbbRoom_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(969, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày kết thúc";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(1188, 92);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(265, 35);
            this.dateEnd.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(969, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(1188, 37);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(265, 35);
            this.dateStart.TabIndex = 17;
            // 
            // cbbStudent
            // 
            this.cbbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStudent.FormattingEnabled = true;
            this.cbbStudent.Location = new System.Drawing.Point(223, 34);
            this.cbbStudent.Name = "cbbStudent";
            this.cbbStudent.Size = new System.Drawing.Size(265, 37);
            this.cbbStudent.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Học sinh";
            // 
            // dgvContract
            // 
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column12});
            this.dgvContract.Location = new System.Drawing.Point(6, 148);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.RowTemplate.Height = 28;
            this.dgvContract.Size = new System.Drawing.Size(1469, 248);
            this.dgvContract.TabIndex = 0;
            this.dgvContract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContract_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvRent);
            this.groupBox3.Controls.Add(this.btnPay);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 582);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1483, 326);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán tiền phòng";
            // 
            // dgvRent
            // 
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.s,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvRent.Location = new System.Drawing.Point(19, 34);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.RowTemplate.Height = 28;
            this.dgvRent.Size = new System.Drawing.Size(1456, 162);
            this.dgvRent.TabIndex = 5;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã hợp đồng";
            this.Column8.Name = "Column8";
            // 
            // s
            // 
            this.s.HeaderText = "Tháng-Năm";
            this.s.Name = "s";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Giá";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ngày thanh toán";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Nhân viên";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hợp đồng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Học sinh";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phòng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày bắt đầu";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày kết thúc";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tiền đặt cọc";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giá thực tế";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Tình trạng";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // frmRentRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 920);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmRentRoom";
            this.Text = "Thuê phòng";
            this.Load += new System.EventHandler(this.frmRentRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.Button btnResetContract;
        private System.Windows.Forms.Button btnEditContract;
        private System.Windows.Forms.Button btnDeleteContract;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.NumericUpDown txtPriceActual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtDesposit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.ComboBox cbbStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn s;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}