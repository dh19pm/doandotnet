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
    public partial class GUI_Bill : Form
    {
        BUS_Bill bus = new BUS_Bill();
        private int index = -1;
        public GUI_Bill()
        {
            InitializeComponent();
        }

        private void GUI_Bill_Load(object sender, EventArgs e)
        {
            bus.ShowDGV(dataGridView, bindingNavigator);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GUI_Bill_Load(sender, e);
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    this.index = row.Index;
                if (this.index >= 0)
                {
                    int id = Convert.ToInt32(dataGridView.Rows[this.index].Cells["colId"].Value);
                    DTO_Bill info = new DTO_Bill();
                    info.Id = id;
                    bus.dropItem(info);
                    GUI_Bill_Load(sender, e);
                }
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                this.index = row.Index;
            if (this.index >= 0)
            {
                int id = Convert.ToInt32(dataGridView.Rows[this.index].Cells["colId"].Value);
                GUI_Export_Bill frm = new GUI_Export_Bill(id);
                frm.ShowDialog();
            }
        }
    }
}
