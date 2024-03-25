namespace GUI.FRM
{
    partial class frmStatistical
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatistical = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lbTemp = new System.Windows.Forms.Label();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.rdoYear = new System.Windows.Forms.RadioButton();
            this.rdoMonth = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(985, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thống kê doanh thu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatistical);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInventory);
            this.groupBox1.Controls.Add(this.lbTemp);
            this.groupBox1.Controls.Add(this.cbbYear);
            this.groupBox1.Controls.Add(this.cbbMonth);
            this.groupBox1.Controls.Add(this.rdoYear);
            this.groupBox1.Controls.Add(this.rdoMonth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng điều khiển";
            // 
            // txtStatistical
            // 
            this.txtStatistical.Enabled = false;
            this.txtStatistical.Location = new System.Drawing.Point(205, 181);
            this.txtStatistical.Name = "txtStatistical";
            this.txtStatistical.Size = new System.Drawing.Size(281, 35);
            this.txtStatistical.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doanh thu";
            // 
            // btnInventory
            // 
            this.btnInventory.AutoSize = true;
            this.btnInventory.Location = new System.Drawing.Point(205, 101);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(125, 39);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Thống kê";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(336, 53);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(20, 29);
            this.lbTemp.TabIndex = 4;
            this.lbTemp.Text = "/";
            // 
            // cbbYear
            // 
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(365, 45);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(121, 37);
            this.cbbYear.TabIndex = 3;
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Location = new System.Drawing.Point(209, 45);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(121, 37);
            this.cbbMonth.TabIndex = 2;
            // 
            // rdoYear
            // 
            this.rdoYear.AutoSize = true;
            this.rdoYear.Location = new System.Drawing.Point(23, 104);
            this.rdoYear.Name = "rdoYear";
            this.rdoYear.Size = new System.Drawing.Size(89, 33);
            this.rdoYear.TabIndex = 1;
            this.rdoYear.Text = "Năm";
            this.rdoYear.UseVisualStyleBackColor = true;
            this.rdoYear.CheckedChanged += new System.EventHandler(this.rdoYear_CheckedChanged);
            // 
            // rdoMonth
            // 
            this.rdoMonth.AutoSize = true;
            this.rdoMonth.Checked = true;
            this.rdoMonth.Location = new System.Drawing.Point(23, 45);
            this.rdoMonth.Name = "rdoMonth";
            this.rdoMonth.Size = new System.Drawing.Size(107, 33);
            this.rdoMonth.TabIndex = 0;
            this.rdoMonth.TabStop = true;
            this.rdoMonth.Text = "Tháng";
            this.rdoMonth.UseVisualStyleBackColor = true;
            this.rdoMonth.CheckedChanged += new System.EventHandler(this.rdoMonth_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRoom);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(985, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.phone,
            this.Column1,
            this.Column2});
            this.dgvRoom.Location = new System.Drawing.Point(8, 103);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowTemplate.Height = 28;
            this.dgvRoom.Size = new System.Drawing.Size(969, 262);
            this.dgvRoom.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "Mã phòng";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Tên phòng";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Diện tích";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số giường";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giá thuê";
            this.Column2.Name = "Column2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(112, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(759, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách phòng còn trống";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvContract);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(985, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hợp đồng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvContract
            // 
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvContract.Location = new System.Drawing.Point(8, 151);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.RowTemplate.Height = 28;
            this.dgvContract.Size = new System.Drawing.Size(969, 295);
            this.dgvContract.TabIndex = 4;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã hợp đồng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phòng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Học sinh";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày hết hạn";
            this.Column6.Name = "Column6";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(99, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(759, 125);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách hợp đồng sắp hết hạn hoặc hết hạn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmStatistical";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmStatistical_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoYear;
        private System.Windows.Forms.RadioButton rdoMonth;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtStatistical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label4;
    }
}