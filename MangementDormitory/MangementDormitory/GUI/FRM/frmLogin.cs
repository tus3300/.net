using BUS;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtUsername) || !ValidateTextBox(txtPassword))
                return;
            var staff = StaffBUS.Login(txtUsername.Text, txtPassword.Text);
            if (staff == null)
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Hide();
                new frmMain(this, staff).Show();
            }

        }
    }
}
