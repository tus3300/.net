namespace GUI.FRM
{
    partial class frmRoom
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
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.NumericUpDown();
            this.txtNumberOfBeds = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng";
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
            this.dgvRoom.Location = new System.Drawing.Point(5, 352);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowTemplate.Height = 28;
            this.dgvRoom.Size = new System.Drawing.Size(959, 262);
            this.dgvRoom.TabIndex = 3;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
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
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::GUI.Properties.Resources.open_box;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(800, 629);
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
            this.btnEdit.Location = new System.Drawing.Point(578, 629);
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
            this.btnDelete.Location = new System.Drawing.Point(300, 629);
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
            this.btnAdd.Location = new System.Drawing.Point(21, 629);
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
            this.groupBox1.Location = new System.Drawing.Point(5, 234);
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
            this.txtName.Tag = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Diện tích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giá thuê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số giường";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(659, 94);
            this.txtArea.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(269, 35);
            this.txtArea.TabIndex = 15;
            this.txtArea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNumberOfBeds
            // 
            this.txtNumberOfBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfBeds.Location = new System.Drawing.Point(214, 176);
            this.txtNumberOfBeds.Name = "txtNumberOfBeds";
            this.txtNumberOfBeds.Size = new System.Drawing.Size(236, 35);
            this.txtNumberOfBeds.TabIndex = 16;
            this.txtNumberOfBeds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(659, 173);
            this.txtPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(269, 35);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 707);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumberOfBeds);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRoom";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtArea;
        private System.Windows.Forms.NumericUpDown txtNumberOfBeds;
        private System.Windows.Forms.NumericUpDown txtPrice;
    }
}