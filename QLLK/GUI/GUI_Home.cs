using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLK.GUI
{
    public partial class GUI_Home : Form
    {
        DataRow Account;
        GUI_Account frmAccount = null;
        GUI_Category frmCategory = null;
        GUI_Producer frmProducer = null;
        GUI_Product frmProduct = null;
        GUI_Origin frmOrigin = null;
        GUI_Bill frmBill = null;
        GUI_Customer frmCustomer = null;
        GUI_Revenue frmRevenue = null;

        public GUI_Home()
        {
            InitializeComponent();
        }
        private void resetBtn(bool val)
        {
            btnLogout.Enabled = val;
            btnLogin.Enabled = !val;
            btnAccounts.Enabled = val;
            btnBill.Enabled = val;
            btnRevenue.Enabled = val;
            btnCustomer.Enabled = val;
            btnProducts.Enabled = val;
        }
        private void checkLogin()
        {
            if (Account != null)
            {
                if (Convert.ToInt32(Account["position"]) == 0)
                {
                    menuStrip.Enabled = false;
                    btnAccounts.Enabled = false;
                    btnRevenue.Enabled = false;
                    btnCustomer.Enabled = false;
                }

                if (Convert.ToInt32(Account["position"]) == 1)
                {
                    menuStrip.Enabled = true;
                }
            }
        }

        private void resetForm()
        {
            foreach (Form frm in MdiChildren)
                frm.Close();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (frmCategory == null || frmCategory.IsDisposed)
            {
                frmCategory = new GUI_Category();
                frmCategory.MdiParent = this;
                frmCategory.Dock = DockStyle.Fill;
                frmCategory.FormBorderStyle = FormBorderStyle.None;
                frmCategory.Show();
            }
            else
                frmCategory.Activate();
        }

        private void btnProducer_Click(object sender, EventArgs e)
        {
            if (frmProducer == null || frmProducer.IsDisposed)
            {
                frmProducer = new GUI_Producer();
                frmProducer.MdiParent = this;
                frmProducer.Dock = DockStyle.Fill;
                frmProducer.FormBorderStyle = FormBorderStyle.None;
                frmProducer.Show();
            }
            else
                frmProducer.Activate();
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            if (frmOrigin == null || frmOrigin.IsDisposed)
            {
                frmOrigin = new GUI_Origin();
                frmOrigin.MdiParent = this;
                frmOrigin.Dock = DockStyle.Fill;
                frmOrigin.FormBorderStyle = FormBorderStyle.None;
                frmOrigin.Show();
            }
            else
                frmOrigin.Activate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                resetBtn(false);
                Account = null;
                resetForm();
            }
        }

        private void GUI_Home_Load(object sender, EventArgs e)
        {
            resetBtn(false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GUI_Login login = new GUI_Login();
            login.ShowDialog();
            Account = login.Account;
            if (Account != null)
            {
                resetBtn(true);
                checkLogin();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (frmProduct == null || frmProduct.IsDisposed)
            {
                frmProduct = new GUI_Product(Account);
                frmProduct.MdiParent = this;
                frmProduct.Dock = DockStyle.Fill;
                frmProduct.FormBorderStyle = FormBorderStyle.None;
                frmProduct.Show();
            }
            else
                frmProduct.Activate();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (frmBill == null || frmBill.IsDisposed)
            {
                frmBill = new GUI_Bill();
                frmBill.MdiParent = this;
                frmBill.Dock = DockStyle.Fill;
                frmBill.FormBorderStyle = FormBorderStyle.None;
                frmBill.Show();
            }
            else
                frmBill.Activate();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (frmCustomer == null || frmCustomer.IsDisposed)
            {
                frmCustomer = new GUI_Customer();
                frmCustomer.MdiParent = this;
                frmCustomer.Dock = DockStyle.Fill;
                frmCustomer.FormBorderStyle = FormBorderStyle.None;
                frmCustomer.Show();
            }
            else
                frmCustomer.Activate();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            if (frmRevenue == null || frmRevenue.IsDisposed)
            {
                frmRevenue = new GUI_Revenue();
                frmRevenue.MdiParent = this;
                frmRevenue.Dock = DockStyle.Fill;
                frmRevenue.FormBorderStyle = FormBorderStyle.None;
                frmRevenue.Show();
            }
            else
                frmRevenue.Activate();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            if (frmAccount == null || frmAccount.IsDisposed)
            {
                frmAccount = new GUI_Account();
                frmAccount.MdiParent = this;
                frmAccount.Dock = DockStyle.Fill;
                frmAccount.FormBorderStyle = FormBorderStyle.None;
                frmAccount.Show();
            }
            else
                frmAccount.Activate();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Truy cập vào siben.vn để biết thêm chi tiết.", "Thông Tin Phần Mềm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Được phát triển bởi Sĩ Ben.", "Thông Tin Phần Mềm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
