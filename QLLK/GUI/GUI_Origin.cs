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
    public partial class GUI_Origin : Form
    {
        BUS_Origin bus = new BUS_Origin();
        private string action;
        private int index;

        public GUI_Origin()
        {
            InitializeComponent();
        }
        private void endableAll(bool val)
        {
            btnAdd.Enabled = val;
            btnDrop.Enabled = val;
            btnEdit.Enabled = val;
            btnSave.Enabled = !val;
        }
        private void resetInput()
        {
            txtId.Clear();
            txtName.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetInput();
            this.action = "add";
            endableAll(false);
            groupBox.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.action = "edit";
            endableAll(false);
            groupBox.Enabled = true;
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                DTO_Origin info = new DTO_Origin();
                info.Id = Convert.ToInt32(txtId.Text);
                bus.dropItem(info);
                GUI_Origin_Load(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập xuất sứ !", "Thông báo");
            }
            DTO_Origin info = new DTO_Origin();
            info.Name = txtName.Text;
            if (this.action == "add")
                bus.addItem(info);
            if (this.action == "edit")
            {
                info.Id = Convert.ToInt32(txtId.Text);
                bus.editItem(info);
            }
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                this.index = row.Index;

            GUI_Origin_Load(sender, e);
            endableAll(true);
            groupBox.Enabled = false;
            dataGridView.CurrentCell = dataGridView.Rows[this.index].Cells[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GUI_Origin_Load(sender, e);
        }

        private void GUI_Origin_Load(object sender, EventArgs e)
        {
            bus.ShowDGV(dataGridView, bindingNavigator, txtId, txtName);
            groupBox.Enabled = false;
            endableAll(true);
        }
    }
}
