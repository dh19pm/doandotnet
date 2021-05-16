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
    public partial class GUI_Product : Form
    {
        BUS_Product bus = new BUS_Product();
        string action;
        int index;
        List<string> bill = new List<string>();
        DataRow Account;

        public GUI_Product(DataRow Account)
        {
            this.Account = Account;
            InitializeComponent();
        }

        private void GUI_Product_Load(object sender, EventArgs e)
        {
            groupBox.Enabled = false;
            bus.ShowCBB(cboCategory, cboProducer, cboOrigin);
            bus.ShowDGV(dataGridView, bindingNavigator, cboCategory, cboProducer, cboOrigin, txtId, txtName, txtAmount, txtPrice, txtWarrantyDate, txtSearch);
            endableAll(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupBox.Enabled = true;
            this.action = "add";
            endableAll(false);
            resetInput();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox.Enabled = true;
            this.action = "edit";
            endableAll(false);
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                bus.dropItem(Convert.ToInt32(txtId.Text));
                GUI_Product_Load(sender, e);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAmount.Text == "" || txtPrice.Text == "" || txtWarrantyDate.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên cho sản phẩm", "Thông báo");
                return;
            }

            if (!isInt(txtAmount.Text))
            {
                MessageBox.Show("Số lượng phải là số !", "Thông báo");
                return;
            }

            if (!isInt(txtPrice.Text))
            {
                MessageBox.Show("Giá tiền phải là số !", "Thông báo");
                return;
            }

            if (!isInt(txtWarrantyDate.Text))
            {
                MessageBox.Show("Thời hạn bảo hành phải là số !", "Thông báo");
                return;
            }

            DTO_Product info = new DTO_Product();
            info.Account.Id = Convert.ToInt32(Account["id"]);
            info.Category.Id = Convert.ToInt32(cboCategory.SelectedValue);
            info.Producer.Id = Convert.ToInt32(cboProducer.SelectedValue);
            info.Origin.Id = Convert.ToInt32(cboOrigin.SelectedValue);
            info.Name = txtName.Text;
            info.Amount = Convert.ToInt32(txtAmount.Text);
            info.Price = Convert.ToInt32(txtPrice.Text);
            info.WarrantyPeriod = Convert.ToInt32(txtWarrantyDate.Text);

            if (this.action == "add")
                bus.addItem(info);

            if (this.action == "edit")
                bus.editItem(Convert.ToInt32(txtId.Text), info);

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                this.index = row.Index;

            GUI_Product_Load(sender, e);
            endableAll(true);
            groupBox.Enabled = false;
            dataGridView.CurrentCell = dataGridView.Rows[this.index].Cells[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GUI_Product_Load(sender, e);
            endableAll(true);
            this.bill.Clear();
        }

        private void endableAll(bool val)
        {
            btnAdd.Enabled = val;
            btnDrop.Enabled = val;
            btnEdit.Enabled = val;
            btnSave.Enabled = !val;
        }

        public void resetInput()
        {
            txtId.Clear();
            txtName.Clear();
            txtAmount.Clear();
            txtPrice.Clear();
            txtWarrantyDate.Clear();
            if(cboCategory.SelectedIndex != -1)
                cboCategory.SelectedIndex = 0;
            if (cboOrigin.SelectedIndex != -1)
                cboOrigin.SelectedIndex = 0;
            if (cboProducer.SelectedIndex != -1)
                cboProducer.SelectedIndex = 0;
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            GUI_Product_Load(sender, e);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.bill.Clear();
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                if(Convert.ToInt32(row.Cells["colChecked"].Value) == 1)
                {
                    this.bill.Add(row.Cells["colId"].Value.ToString() + "|" + row.Cells["colAmountBuy"].Value.ToString());
                }
            }
            string[] temp = this.bill.ToArray();
            if (temp.Length < 1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần mua để lập hóa đơn!");
                return;
            }
            GUI_Create_Bill form = new GUI_Create_Bill(temp, Account);
            form.ShowDialog();
            GUI_Product_Load(sender, e);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 10)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                row.Cells["colChecked"].Value = Convert.ToBoolean(row.Cells["colChecked"].EditedFormattedValue) == true ? 1 : 0;
                if (Convert.ToInt32(row.Cells["colChecked"].Value) == 1)
                {
                    if (Convert.ToInt32(row.Cells["colAmountBuy"].Value) == 0)
                        row.Cells["colAmountBuy"].Value = 1;
                }
                else
                {
                    row.Cells["colAmountBuy"].Value = 0;
                }
                MessageBox.Show("Đã lưu thay đổi", "Thông báo");
            }
        }
        private bool isInt(string txt)
        {
            int output;
            if (int.TryParse(txt, out output))
                return true;
            return false;
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 9)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                if (!isInt(row.Cells["colAmountBuy"].Value.ToString()))
                {
                    MessageBox.Show("Vui lòng nhập số lượng mua là số!");
                    row.Cells["colAmountBuy"].Value = 0;
                }
                if(Convert.ToInt32(row.Cells["colAmountBuy"].Value.ToString()) > Convert.ToInt32(row.Cells["colAmount"].Value))
                {
                    MessageBox.Show("Vui lòng nhập số lượng mua phải <= số lượng hiện có!");
                    row.Cells["colAmountBuy"].Value = 0;
                }
            }
        }
    }
}
