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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }


        private void frmStudent_Load(object sender, EventArgs e)
        {
            InitCBBClass();
            InitColumnGridView();
            SetDataGridView();
        }
        private void InitCBBClass()
        {
            cbbClass.ValueMember = "id";
            cbbClass.DisplayMember = "name";
            cbbClass.DataSource = ClassBUS.GetData();

        }
        //khởi tạo cột gridview
        private void InitColumnGridView()
        {
            dgvStudent.Columns[0].DataPropertyName = "studentCode";
            dgvStudent.Columns[1].DataPropertyName = "name";
            dgvStudent.Columns[2].DataPropertyName = "phone";
            DataGridViewComboBoxColumn comboxColumn = (DataGridViewComboBoxColumn)dgvStudent.Columns[3];
            comboxColumn.DataSource = ClassBUS.GetData();
            comboxColumn.DisplayMember = "name";
            comboxColumn.ValueMember = "id";
            dgvStudent.Columns[3].DataPropertyName = "classId";
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SetDataGridView()
        {
            dgvStudent.DataSource = StudentBUS.GetData();
            dgvStudent.Columns[4].Visible = false;

            if (dgvStudent.SelectedRows.Count >= 0)
                DisplayTextBox();
        }
        //clear text box
        private void Clear()
        {
            txtStudentCode.Enabled = true;
            txtName.Clear();
            txtStudentCode.Focus();
            txtPhone.Clear();
            txtStudentCode.Clear();
            cbbClass.SelectedIndex = 0;
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
                txtStudentCode.Text = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
                txtPhone.Text = dgvStudent.SelectedRows[0].Cells[2].Value.ToString();
                cbbClass.SelectedValue = int.Parse(dgvStudent.SelectedRows[0].Cells[3].Value.ToString());
                txtStudentCode.Enabled = false;
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
            if (!ValidateTextBox(txtStudentCode) || !ValidateTextBox(txtName) || !ValidateTextBox(txtPhone))
                return;
            var model = new Student
            {
                name = txtName.Text.Trim(),
                classId = int.Parse(cbbClass.SelectedValue.ToString()),
                phone = txtPhone.Text.Trim(),
                studentCode = txtStudentCode.Text.Trim()
            };
            var i = StudentBUS.Insert(model);
            if (i == -1)
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (i == 0)
                MessageBox.Show("Trùng mã học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (dgvStudent.SelectedRows.Count <= 0)
                MessageBox.Show("Chọn dòng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn chắc chắn xoá dòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var studentCode = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
                var i = StudentBUS.Delete(studentCode);
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
            if (dgvStudent.SelectedRows.Count > 0)
            {
                if (!ValidateTextBox(txtName) || !ValidateTextBox(txtPhone))
                    return;
                var model = new Student
                {
                    name = txtName.Text.Trim(),
                    classId = int.Parse(cbbClass.SelectedValue.ToString()),
                    phone = txtPhone.Text.Trim(),
                    studentCode = txtStudentCode.Text.Trim()
                };
                var i = StudentBUS.Update(model);
                if (i == -1)
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }
                txtStudentCode.Enabled = true;
                SetDataGridView();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dgvStudent.DataSource = StudentBUS.Search(txtSearch.Text);
                if (dgvStudent.SelectedRows.Count >= 0)
                    DisplayTextBox();
            }
            else
                SetDataGridView();

        }


    }
}
