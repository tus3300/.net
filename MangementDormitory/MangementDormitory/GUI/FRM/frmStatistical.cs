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
    public partial class frmStatistical : Form
    {
        public frmStatistical()
        {
            InitializeComponent();
        }
        private void frmStatistical_Load(object sender, EventArgs e)
        {
            InitCBB();
            InitColumnGVRoom();
            SetDataGVRoom();
            InitColumnGVContract();
            SetDataGVContract();
        }
        //khởi tạo cột gridview
        private void InitColumnGVRoom()
        {
            dgvRoom.Columns[0].DataPropertyName = "id";
            dgvRoom.Columns[1].DataPropertyName = "name";
            dgvRoom.Columns[2].DataPropertyName = "area";
            dgvRoom.Columns[3].DataPropertyName = "numberOfBeds";
            dgvRoom.Columns[4].DataPropertyName = "price";
            dgvRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SetDataGVRoom()
        {
            dgvRoom.DataSource = StatisticalBUS.ListRoomEmpty();
        }
        //khởi tạo cột gridview
        private void InitColumnGVContract()
        {
            dgvContract.Columns[0].DataPropertyName = "id";
            dgvContract.Columns[1].DataPropertyName = "room";
            dgvContract.Columns[2].DataPropertyName = "student";
            dgvContract.Columns[3].DataPropertyName = "dateEnd";
            dgvContract.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContract.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SetDataGVContract()
        {
            dgvContract.DataSource = StatisticalBUS.ContractExpired();
        }
        private void InitCBB()
        {
            //data cbb month
            var months = new List<int>();
            for (int i = 1; i < 13; i++)
                months.Add(i);
            cbbMonth.DataSource = months;
            cbbMonth.SelectedIndex = 0;
            //data cbb year
            var years = new List<int>();
            for (int i = DateTime.Now.Year; i >= 2000; i--)
                years.Add(i);
            cbbYear.DataSource = years;
            cbbYear.SelectedIndex = 0;
        }
        private void Visiable(bool status)
        {
            lbTemp.Visible = cbbMonth.Visible = status;
        }
        private void rdoMonth_CheckedChanged(object sender, EventArgs e)
        {
            Visiable(true);
        }

        private void rdoYear_CheckedChanged(object sender, EventArgs e)
        {
            Visiable(false);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            double money = 0;
            if (rdoMonth.Checked)
                money = StatisticalBUS.Inventory(int.Parse(cbbYear.SelectedValue.ToString()), int.Parse(cbbMonth.SelectedValue.ToString()));
            else
                money = StatisticalBUS.Inventory(int.Parse(cbbYear.SelectedValue.ToString()));
            txtStatistical.Text = Library.convertVND(money.ToString());
        }


    }
}
