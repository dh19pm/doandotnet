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
        DataRow account;
        private int position;
        public DataRow Account { get => account; set => account = value; }
        public int Position { get => position; set => position = value; }

        public GUI_Home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GUI_Login login = new GUI_Login();
            login.ShowDialog();
            Account = login.Account;
            if (Account != null)
            {
                Position = Convert.ToInt32(Account["position"]);
                checkLogin(true);
                txtUsername.Text = Account["username"].ToString();
                txtPosition.Text = (Position == 1 ? "Quản lý" : "Nhân viên");
                txtCreateDate.Text = Convert.ToDateTime(Account["create_date"]).ToString("dd/MM/yyyy");
            }
        }
        private void checkLogin(bool val)
        {
            lbUsername.Visible = val;
            lbPosition.Visible = val;
            lbCreateDate.Visible = val;
            txtUsername.Visible = val;
            txtPosition.Visible = val;
            txtCreateDate.Visible = val;
            btnLogout.Visible = val;
            btnLogin.Visible = !val;
            if(Account != null)
            {
                if(Position == 1)
                    menuStrip.Enabled = val;
                gpbOption.Enabled = val;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                checkLogin(false);
                Account = null;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            GUI_Product form = new GUI_Product();
            form.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            GUI_Category form = new GUI_Category();
            form.ShowDialog();
        }
    }
}
