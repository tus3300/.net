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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            InitColumnGridView();
            SetDataGridView();
        }
        //khởi tạo cột gridview
        private void InitColumnGridView()
        {
            dgvClass.Columns[0].DataPropertyName = "id";
            dgvClass.Columns[1].DataPropertyName = "name";
            dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SetDataGridView()
        {
            dgvClass.DataSource = ClassBUS.GetData();
            if (dgvClass.SelectedRows.Count >= 0)
                DisplayTextBox();
        }
        //clear text box
        private void Clear()
        {
            txtName.Clear();
            txtName.Focus();
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
                txtName.Text = dgvClass.SelectedRows[0].Cells[1].Value.ToString();
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
            var model = new Class
            {
                name = txtName.Text.ToString().Trim()
            };
            var i = ClassBUS.Insert(model);
            if (i == -1)
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (i == 0)
                MessageBox.Show("Trùng tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (dgvClass.SelectedRows.Count <= 0)
                MessageBox.Show("Chọn dòng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn chắc chắn xoá dòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var id = int.Parse(dgvClass.SelectedRows[0].Cells[0].Value.ToString());
                var i = ClassBUS.Delete(id);
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
        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                DisplayTextBox();
        }
        //sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows.Count > 0)
            {
                if (!ValidateTextBox(txtName))
                    return;
                var model = new Class
                {
                    id = int.Parse(dgvClass.SelectedRows[0].Cells[0].Value.ToString()),
                    name = txtName.Text.Trim()
                };
                var i = ClassBUS.Update(model);
                if (i == -1)
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (i == 0)
                    MessageBox.Show("Trùng tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }
                SetDataGridView();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dgvClass.DataSource = ClassBUS.Search(txtSearch.Text);
                if (dgvClass.SelectedRows.Count >= 0)
                    DisplayTextBox();
            }
            else
                SetDataGridView();

        }
    }
}
