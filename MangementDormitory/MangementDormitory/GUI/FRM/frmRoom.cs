using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FRM
{
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }
        private void frmRoom_Load(object sender, EventArgs e)
        {
            InitColumnGridView();
            SetDataGridView();
        }

        //khởi tạo cột gridview
        private void InitColumnGridView()
        {
            dgvRoom.Columns[0].DataPropertyName = "id";
            dgvRoom.Columns[1].DataPropertyName = "name";
            dgvRoom.Columns[2].DataPropertyName = "area";
            dgvRoom.Columns[3].DataPropertyName = "numberOfBeds";
            dgvRoom.Columns[4].DataPropertyName = "price";
            dgvRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SetDataGridView()
        {
            dgvRoom.DataSource = RoomBUS.GetData();
            if (dgvRoom.SelectedRows.Count >= 0)
                DisplayTextBox();
        }
        //clear text box
        private void Clear()
        {
            txtName.Clear();
            txtName.Focus();
            txtArea.Value = 1;
            txtNumberOfBeds.Value = 1;
            txtPrice.Value = 1;
        }
        //reset textbox
        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //hiển thị lên textbox
        private void DisplayTextBox()
        {
            try
            {
                txtName.Text = dgvRoom.SelectedRows[0].Cells[1].Value.ToString();
                txtArea.Value = int.Parse(dgvRoom.SelectedRows[0].Cells[2].Value.ToString());
                txtNumberOfBeds.Value = int.Parse(dgvRoom.SelectedRows[0].Cells[3].Value.ToString());
                txtPrice.Value = int.Parse(dgvRoom.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {


            }
        }
        //kiểm tra đầu vào text box
        private bool ValidateTextBox(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text.Trim()))
            {
                MessageBox.Show(txt.Tag.ToString() + " không được bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return false;
            }
            return true;
        }
        //thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtName))
                return;
            var model = new Room
            {
                name = txtName.Text.Trim(),
                area = int.Parse(txtArea.Value.ToString()),
                numberOfBeds = int.Parse(txtNumberOfBeds.Value.ToString()),
                price = int.Parse(txtPrice.Value.ToString()),
            };
            var i = RoomBUS.Insert(model);
            if (i == -1)
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (i == 0)
                MessageBox.Show("Trùng tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clear();
            }
            SetDataGridView();
        }
        //xoá
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count <= 0)
                MessageBox.Show("Chọn dòng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn chắc chắn xoá dòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var id = int.Parse(dgvRoom.SelectedRows[0].Cells[0].Value.ToString());
                var i = RoomBUS.Delete(id);
                if (i == -1)
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }
                SetDataGridView();
            }
        }
        //chọn 1 dòng hiển thị lại text       
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                DisplayTextBox();
        }
        //sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
            {
                if (!ValidateTextBox(txtName))
                    return;
                var model = new Room
                {
                    id = int.Parse(dgvRoom.SelectedRows[0].Cells[0].Value.ToString()),
                    name = txtName.Text.Trim(),
                    area = int.Parse(txtArea.Value.ToString()),
                    numberOfBeds = int.Parse(txtNumberOfBeds.Value.ToString()),
                    price = int.Parse(txtPrice.Value.ToString()),
                };
                var i = RoomBUS.Update(model);
                if (i == -1)
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (i == 0)
                    MessageBox.Show("Trùng tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }
                txtName.Enabled = true;
                SetDataGridView();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dgvRoom.DataSource = RoomBUS.Search(txtSearch.Text);
                if (dgvRoom.SelectedRows.Count >= 0)
                    DisplayTextBox();
            }
            else
                SetDataGridView();

        }


    }
}
