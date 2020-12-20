using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using QLLK.BUS;
using QLLK.DTO;

namespace QLLK.GUI
{
    public partial class GUI_Account : Form
    {
        BUS_Account bus = new BUS_Account();
        private string action;
        private int index;
        public GUI_Account()
        {
            InitializeComponent();
            cboPosition.DisplayMember = "Text";
            cboPosition.ValueMember = "Value";
            cboPosition.Items.Add(new ItemComboBox { Text = "Quản lý", Value = "1" });
            cboPosition.Items.Add(new ItemComboBox { Text = "Nhân viên", Value = "0" });
            cboPosition.SelectedIndex = 0;
        }
        public class ItemComboBox
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString()
            {
                return Value;
            }
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
            txtPass.Clear();
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
                DTO_Account info = new DTO_Account();
                info.Id = Convert.ToInt32(txtId.Text);
                bus.dropItem(info);
                GUI_Account_Load(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên tài khoản!", "Thông báo");
                return;
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người dùng tài khoản!", "Thông báo");
                return;
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                return;
            }

            DTO_Account info = new DTO_Account();
            info.Fullname = txtFullname.Text;
            info.Username = txtName.Text;
            info.Password = txtPass.Text;
            info.Position = Convert.ToInt32(cboPosition.SelectedItem.ToString());

            if (this.action == "add")
                bus.addItem(info);
            if (this.action == "edit")
            {
                info.Id = Convert.ToInt32(txtId.Text);
                bus.editItem(info);
            }

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                this.index = row.Index;

            GUI_Account_Load(sender, e);
            endableAll(true);
            groupBox.Enabled = false;
            dataGridView.CurrentCell = dataGridView.Rows[this.index].Cells[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GUI_Account_Load(sender, e);
        }

        private void GUI_Account_Load(object sender, EventArgs e)
        {
            bus.ShowDGV(dataGridView, bindingNavigator, txtId, txtFullname, txtName, txtPass,cboPosition);
            groupBox.Enabled = false;
            endableAll(true);
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dataGridView.Columns[e.ColumnIndex].Name == "colPosotion")
            {
                e.Value = e.Value.ToString() == "1" ? "Quản lý" : "Nhân viên";
            }
        }
    }
}
