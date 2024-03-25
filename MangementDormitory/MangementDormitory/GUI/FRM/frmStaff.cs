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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            InitCBBRole();
            InitColumnGridView();
            SetDataGridView();
        }
        private void InitCBBRole()
        {
            cbbRole.ValueMember = "id";
            cbbRole.DisplayMember = "name";
            cbbRole.DataSource = RoleBUS.GetData();

        }
        //khởi tạo cột gridview
        private void InitColumnGridView()
        {
            dgvStaff.Columns[0].DataPropertyName = "id";
            dgvStaff.Columns[1].DataPropertyName = "name";
            dgvStaff.Columns[2].DataPropertyName = "phone";
            DataGridViewComboBoxColumn comboxColumn = (DataGridViewComboBoxColumn)dgvStaff.Columns[3];
            comboxColumn.DataSource = RoleBUS.GetData();
            comboxColumn.DisplayMember = "name";
            comboxColumn.ValueMember = "id";
            dgvStaff.Columns[3].DataPropertyName = "roleId";
            dgvStaff.Columns[4].DataPropertyName = "note";
            dgvStaff.Columns[5].DataPropertyName = "username";
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SetDataGridView()
        {
            dgvStaff.DataSource = StaffBUS.GetData();
            dgvStaff.Columns[6].Visible = false;
            dgvStaff.Columns[7].Visible = false;

            if (dgvStaff.SelectedRows.Count > 0)
                DisplayTextBox();
        }
        //clear text box
        private void Clear()
        {
            txtName.Clear();
            txtName.Focus();
            txtPhone.Clear();
            txtNote.Clear();
            txtUsername.Clear();
            cbbRole.SelectedIndex = 0;
            txtUsername.Enabled = true;
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
                txtUsername.Enabled = false;
                txtUsername.Text = dgvStaff.SelectedRows[0].Cells[5].Value.ToString();
                txtName.Text = dgvStaff.SelectedRows[0].Cells[1].Value.ToString();
                txtPhone.Text = dgvStaff.SelectedRows[0].Cells[2].Value.ToString();
                txtNote.Text = dgvStaff.SelectedRows[0].Cells[3].Value.ToString();
                cbbRole.SelectedValue = int.Parse(dgvStaff.SelectedRows[0].Cells[4].Value.ToString());
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
            if (!ValidateTextBox(txtName) || !ValidateTextBox(txtUsername) || !ValidateTextBox(txtPhone))
                return;
            var model = new Staff
            {
                username = txtUsername.Text.Trim(),
                name = txtName.Text.Trim(),
                roleId = int.Parse(cbbRole.SelectedValue.ToString()),
                phone = txtPhone.Text.Trim(),
                note = txtNote.Text.Trim()
            };
            var i = StaffBUS.Insert(model);
            if (i == -1)
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (i == -1)
                MessageBox.Show("Trùng tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Thêm thành công. Mật khẩu mặc định là 12345", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clear();
            }
            SetDataGridView();
        }
        //xoá
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count <= 0)
                MessageBox.Show("Chọn dòng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn chắc chắn xoá dòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var id = int.Parse(dgvStaff.SelectedRows[0].Cells[0].Value.ToString());
                var i = StaffBUS.Delete(id);
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
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                DisplayTextBox();

        }
        //sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                if (!ValidateTextBox(txtName) || !ValidateTextBox(txtPhone))
                    return;
                var model = new Staff
                {
                    id = int.Parse(dgvStaff.SelectedRows[0].Cells[0].Value.ToString()),
                    name = txtName.Text.Trim(),
                    roleId = int.Parse(cbbRole.SelectedValue.ToString()),
                    phone = txtPhone.Text.Trim(),
                    note = txtNote.Text.Trim()
                };
                var i = StaffBUS.Update(model);
                if (i == -1)
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }
                txtUsername.Enabled = true;
                SetDataGridView();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dgvStaff.DataSource = StaffBUS.Search(txtSearch.Text);
                if (dgvStaff.SelectedRows.Count >= 0)
                    DisplayTextBox();
            }
            else
                SetDataGridView();

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
               
                var i = StaffBUS.ResetPassword(int.Parse(dgvStaff.SelectedRows[0].Cells[0].Value.ToString()));
                if (i == -1)
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Reset mật khẩu thành công. Mật khẩu mới là 12345", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }
                txtUsername.Enabled = true;
                SetDataGridView();

            }
        }
    }
}
