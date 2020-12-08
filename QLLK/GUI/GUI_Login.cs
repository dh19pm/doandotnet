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
using QLLK.GUI;

namespace QLLK
{
    public partial class GUI_Login : Form
    {
        BUS_Login bus = new BUS_Login();

        DataRow account;
        public DataRow Account { get => account; set => account = value; }

        public GUI_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DTO_Account info = new DTO_Account();
            info.Username = txtUsername.Text;
            info.Password = txtPassword.Text;
            DataRow data = bus.getLogin(info);
            if (data != null)
            {
                Account = data;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không tồn tại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
