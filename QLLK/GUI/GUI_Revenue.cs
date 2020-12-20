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
    public partial class GUI_Revenue : Form
    {
        BUS_Revenue bus = new BUS_Revenue();
        public GUI_Revenue()
        {
            InitializeComponent();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            DateTime begin = Convert.ToDateTime(dtpBegin.Value);
            DateTime end = Convert.ToDateTime(dtpEnd.Value);
            if(begin > end)
            {
                MessageBox.Show("Vui lòng nhập ngày bắt đầu nhỏ hơn ngày kết thúc!");
            }
            else
            {
                int result = bus.getRevenue(begin, end);
                if (result == 0)
                {
                    MessageBox.Show("Ngày bạn chọn không có doanh thu nào!");
                }
                else
                {
                    txtResult.Text = bus.getRevenue(begin, end).ToString();
                }
            }
        }
    }
}
