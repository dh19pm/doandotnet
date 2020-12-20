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
    public partial class GUI_Customer : Form
    {
        BUS_Customer bus = new BUS_Customer();
        private string action;
        private int index = -1;
        public GUI_Customer()
        {
            InitializeComponent();
        }

        private void GUI_Customer_Load(object sender, EventArgs e)
        {
            bus.ShowDGV(dataGridView, bindingNavigator, txtId, txtFullname, txtPhonenumber, txtAddress);
            groupBox.Enabled = false;
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                DTO_Customer info = new DTO_Customer();
                info.Id = Convert.ToInt32(txtId.Text);
                bus.dropItem(info);
                GUI_Customer_Load(sender, e);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GUI_Customer_Load(sender, e);
            endableAll(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox.Enabled = true;
            this.action = "edit";
            endableAll(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DTO_Customer info = new DTO_Customer();
            info.Id = Convert.ToInt32(txtId.Text);
            info.Fullname = txtFullname.Text;
            info.Address = txtAddress.Text;
            info.PhoneNumber = txtPhonenumber.Text;

            if (this.action == "edit")
                bus.editItem(info);

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                this.index = row.Index;

            GUI_Customer_Load(sender, e);
            endableAll(true);
            dataGridView.CurrentCell = dataGridView.Rows[this.index].Cells[0];
        }
        private void endableAll(bool val)
        {
            btnDrop.Enabled = val;
            btnEdit.Enabled = val;
            btnSave.Enabled = !val;
        }
    }
}
