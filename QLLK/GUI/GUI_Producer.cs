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
    public partial class GUI_Producer : Form
    {
        BUS_Producer bus = new BUS_Producer();
        private string action;
        private int index;
        public GUI_Producer()
        {
            InitializeComponent();
        }

        private void GUI_Producer_Load(object sender, EventArgs e)
        {
            bus.ShowDGV(dataGridView, bindingNavigator, txtId, txtName);
            endableAll(true);
            groupBox.Enabled = false;
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
            groupBox.Enabled = true;
            endableAll(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.action = "edit";
            groupBox.Enabled = true;
            endableAll(false);
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                DTO_Producer info = new DTO_Producer();
                info.Id = Convert.ToInt32(txtId.Text);
                bus.dropItem(info);
                GUI_Producer_Load(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hãng!", "Thông báo");
                return;
            }

            DTO_Producer info = new DTO_Producer();
            info.Name = txtName.Text;

            if (this.action == "add") 
                bus.addItem(info);
                //MessageBox.Show("text");

            if (this.action == "edit")
            {
                info.Id = Convert.ToInt32(txtId.Text);
                bus.editItem(info);
            }

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                this.index = row.Index;

            GUI_Producer_Load(sender, e);
            endableAll(true);
            groupBox.Enabled = false;
            dataGridView.CurrentCell = dataGridView.Rows[this.index].Cells[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GUI_Producer_Load(sender, e);
        }
    }
}
