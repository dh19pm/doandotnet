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

namespace QLLK.GUI
{
    public partial class GUI_Export_Bill : Form
    {
        private int id = -1;
        BUS_Export_Bill bus = new BUS_Export_Bill();
        public GUI_Export_Bill(int i)
        {
            this.id = i;
            InitializeComponent();
        }

        private void GUI_Export_Bill_Load(object sender, EventArgs e)
        {
            DataRow row = bus.getBill(this.id);
            DataTable list = bus.getProduct(this.id);
            string product = "";
            string result = "";
            result += "Người lập: " + row["account"] + "\n";
            result += "Khách hàng: " + row["customer"] + "\n";
            result += "======================================\n";
            foreach (DataRow rows in list.Rows)
            {
                product += "ID: " + rows["id"] + " - Tên Sản Phẩm: " + rows["name"] + " - Số lượng: " + rows["amount"] + " - Giá tiền: " + rows["price"] + "  - Bảo hành: " + rows["warranty_period"] + " tháng\n";
            }
            result += product + "Tổng Số lượng sản phẩm: " + row["amount"] + "\n";
            result += "======================================\n";
            result += "Tổng tiền: " + row["price"] + "\n";
            result += "Ngày lập: " + Convert.ToDateTime(row["create_date"]).ToString("dd/MM/yyyy") + "\n";
            lbResult.Text = result;
        }
    }
}
