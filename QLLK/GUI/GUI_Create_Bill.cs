using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLK.BUS;
using QLLK.DTO;

namespace QLLK.GUI
{
    public partial class GUI_Create_Bill : Form
    {
        string[] bill;
        BUS_Create_Bill bus = new BUS_Create_Bill();
        public GUI_Create_Bill(string[] temp)
        {
            this.bill = temp;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtFullname.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }
            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!");
                return;
            }
            DTO_Customer info = new DTO_Customer();
            info.Fullname = txtFullname.Text;
            info.PhoneNumber = txtPhoneNumber.Text;
            info.Address = txtAddress.Text;
            bus.addItem(info, this.bill, Convert.ToInt32(txtTotalCost.Text));
            MessageBox.Show("Đã lập hóa đơn", "Thông báo");
            this.Close();
        }

        private void GUI_CreateBill_Load(object sender, EventArgs e)
        {
            txtTotalCost.Text = bus.totalCost(this.bill).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
