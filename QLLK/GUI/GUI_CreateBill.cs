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
    public partial class GUI_CreateBill : Form
    {
        string[] bill;
        public GUI_CreateBill(string[] temp)
        {
            this.bill = temp;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string[] word;
            foreach (string str in this.bill)
            {
                word = str.Split('|');
            }
        }
    }
}
