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
    public partial class frmMain : Form
    {
        Staff staff;
        frmLogin frm;
        public frmMain(frmLogin frm, Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            this.frm = frm;
            labelStaff.Text ="Xin chào: "+ staff.name;
            if(staff.roleId==2)
                btnClass.Visible = btnRoom.Visible = btnStudent.Visible = btnStatistical.Visible = btnStaff.Visible = false;
        }
      
     

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }

       
     

      

        private void openForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.Show();
        }
        private void btnClass_Click(object sender, EventArgs e)
        {
            openForm(new frmClass());
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            openForm(new frmRoom());

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            openForm(new frmStaff());

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            openForm(new frmStudent());

        }

        private void btnRentRoom_Click(object sender, EventArgs e)
        {
            openForm(new frmRentRoom(staff));

        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            openForm(new frmStatistical());

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new frmChangePassword(staff).ShowDialog();
        }

      
    }
}
