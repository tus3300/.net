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
    public partial class frmChangePassword : Form
    {
        private Staff staff;
        public frmChangePassword(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }
        private bool ValidateTextBox(TextBox txt)
        {
            if(string.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show(txt.Tag.ToString() + " không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return false;
            }
            return true;
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtOldPassword) || !ValidateTextBox(txtNewPassword) || !ValidateTextBox(txtPrePassword))
                return;
            var i = StaffBUS.ChangePassword(staff.id, txtOldPassword.Text, txtNewPassword.Text, txtPrePassword.Text);
            if (i == -1)
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (i == -2)
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (i == 0)
                MessageBox.Show("Xác nhận mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
    }
}
