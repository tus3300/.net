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
    public partial class frmRentRoom : Form
    {
        private Staff staff;
        public frmRentRoom(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void frmRentRoom_Load(object sender, EventArgs e)
        {
            InitCBB();
            InitColumnGridView();
            InitGVRent();
            SetDataGridView();

        }
        private void InitCBB()
        {
            //phòng
            cbbRoom.DisplayMember = "name";
            cbbRoom.ValueMember = "id";
            cbbRoom.DataSource = RoomBUS.GetData();
            //học sinh
            cbbStudent.DisplayMember = "name";
            cbbStudent.ValueMember = "studentCode";
            cbbStudent.DataSource = StudentBUS.GetData();
        }
        //khởi tạo cột gridview
        private void InitColumnGridView()
        {
            dgvContract.Columns[0].DataPropertyName = "id";
            DataGridViewComboBoxColumn cbbStudent = (DataGridViewComboBoxColumn)dgvContract.Columns[1];
            cbbStudent.DataSource = StudentBUS.GetData();
            cbbStudent.DisplayMember = "name";
            cbbStudent.ValueMember = "studentCode";
            dgvContract.Columns[1].DataPropertyName = "studentCode";
            DataGridViewComboBoxColumn cbbRoom = (DataGridViewComboBoxColumn)dgvContract.Columns[2];
            cbbRoom.DataSource = RoomBUS.GetData();
            cbbRoom.DisplayMember = "name";
            cbbRoom.ValueMember = "id";
            dgvContract.Columns[2].DataPropertyName = "roomId";
            dgvContract.Columns[3].DataPropertyName = "dateStart";
            dgvContract.Columns[4].DataPropertyName = "dateEnd";
            dgvContract.Columns[5].DataPropertyName = "deposit";
            dgvContract.Columns[6].DataPropertyName = "priceActual";
            dgvContract.Columns[7].DataPropertyName = "expired";
            dgvContract.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContract.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SetDataGridView()
        {
            dgvContract.DataSource = ContractBUS.GetData();
            dgvContract.Columns[9].Visible = false;
            dgvContract.Columns[8].Visible = false;
            if (dgvContract.SelectedRows.Count >= 0)
            {
                DisplayTextBox();
                SetDataGVRent();
            }
        }
        //hiển thị lên textbox
        private void DisplayTextBox()
        {
            try
            {
                EnDisableBtn(false);
                cbbStudent.SelectedValue = dgvContract.SelectedRows[0].Cells[2].Value.ToString();
                cbbRoom.SelectedValue = int.Parse(dgvContract.SelectedRows[0].Cells[3].Value.ToString());
                dateStart.Value = DateTime.Parse(dgvContract.SelectedRows[0].Cells[4].Value.ToString());
                dateEnd.Value = DateTime.Parse(dgvContract.SelectedRows[0].Cells[5].Value.ToString());
                txtDesposit.Value = decimal.Parse(dgvContract.SelectedRows[0].Cells[6].Value.ToString());
                txtPriceActual.Value = decimal.Parse(dgvContract.SelectedRows[0].Cells[7].Value.ToString());
            }
            catch (Exception ex)
            {


            }
        }
        private void Clear()
        {
            cbbStudent.SelectedIndex = 0;
            cbbRoom.SelectedIndex = 0;
            txtDesposit.Value = 1;
            txtPriceActual.Value = 1;
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
            SetPriceActual();
            EnDisableBtn(true);
        }

        private void btnResetContract_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void SetDataGVRent()
        {
            try
            {
                dgvRent.DataSource = RentBUS.GetData(int.Parse(dgvContract.SelectedRows[0].Cells[1].Value.ToString()));
                dgvRent.Columns[0].Visible = false;
                dgvRent.Columns[6].Visible = false;
                dgvRent.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
            }
        }
        private void InitGVRent()
        {
            dgvRent.Columns[0].DataPropertyName = "contractId";
            dgvRent.Columns[1].DataPropertyName = "monthYear";
            dgvRent.Columns[2].DataPropertyName = "price";
            dgvRent.Columns[3].DataPropertyName = "dateOfPayment";
            DataGridViewComboBoxColumn cbbStaff = (DataGridViewComboBoxColumn)dgvRent.Columns[4];
            cbbStaff.DataSource = StaffBUS.GetData();
            cbbStaff.DisplayMember = "name";
            cbbStaff.ValueMember = "id";
            dgvRent.Columns[4].DataPropertyName = "staffId";
            dgvRent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void dgvContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DisplayTextBox();

                SetDataGVRent();
            }
        }
        private void EnDisableBtn(bool status)
        {
            cbbRoom.Enabled = cbbStudent.Enabled = status;
        }
        private void btnAddContract_Click(object sender, EventArgs e)
        {
            if (dateStart.Value > dateEnd.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbStudent.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var model = new Contract
            {
                dateEnd = dateEnd.Value,
                dateStart = dateStart.Value,
                deposit = double.Parse(txtDesposit.Value.ToString()),
                priceActual = double.Parse(txtPriceActual.Value.ToString()),
                roomId = int.Parse(cbbRoom.SelectedValue.ToString()),
                studentCode = cbbStudent.SelectedValue.ToString(),
            };
            var i = ContractBUS.Insert(model);
            if (i == -1)
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (i == 0)
                MessageBox.Show("Học sinh này đang thuê rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (i == -2)
                MessageBox.Show("Phòng này đang có người thuê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clear();
            }
            SetDataGridView();
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            if (dgvContract.SelectedRows.Count <= 0)
                MessageBox.Show("Chọn dòng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Bạn chắc chắn trả phòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var id = int.Parse(dgvContract.SelectedRows[0].Cells[1].Value.ToString());
                var i = ContractBUS.Delete(id);
                if (i == -1)
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    if (i == 0)
                    MessageBox.Show("Hợp đồng chưa hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }
                SetDataGridView();
            }
        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            if (dgvContract.SelectedRows.Count > 0)
            {
                if (dateStart.Value > dateEnd.Value)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var model = new Contract
                {
                    id = int.Parse(dgvContract.SelectedRows[0].Cells[1].Value.ToString()),
                    dateEnd = dateEnd.Value,
                    dateStart = dateStart.Value,
                    deposit = double.Parse(txtDesposit.Value.ToString()),
                };
                var i = ContractBUS.Update(model);
                if (i == -1)
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                }
                SetDataGridView();
                EnDisableBtn(true);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvContract.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn chắc chắn thanh toán tiền phòng tháng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    var model = new Rent
                    {
                        contractId = int.Parse(dgvContract.SelectedRows[0].Cells[1].Value.ToString()),
                        dateOfPayment = DateTime.Now,
                        monthYear = DateTime.Now.Month + "/" + DateTime.Now.Year,
                        price = double.Parse(dgvContract.SelectedRows[0].Cells[7].Value.ToString()),
                        staffId = staff.id,
                    };
                    var i = RentBUS.Insert(model);
                    if (i == -1)
                        MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        if (i == 0)
                        MessageBox.Show("Tháng này đã thanh toán rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    SetDataGVRent();
                }
            }
            else
                MessageBox.Show("Vui lòng chọn hợp đồng để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void SetPriceActual()
        {
            try
            {
                txtPriceActual.Value = decimal.Parse(RoomBUS.FindById(int.Parse(cbbRoom.SelectedValue.ToString())).price.ToString());
            }
            catch (Exception ex)
            {

            }
        }
        private void cbbRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            SetPriceActual();
        }
    }
}
