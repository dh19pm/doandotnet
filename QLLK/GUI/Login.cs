using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLK.DAL;

namespace QLLK
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            Bill b = new Bill();
            string[] value = {"100", "121312", "2020-12-12", "2"};
            b.Update(value);
        }
        /*DataTable table = t.query("SELECT * FROM TYPE_PRODUCTS").fetch();
        foreach (DataRow row in table.Rows)
        {
            this.html += row[0].ToString() + " " + row[1].ToString();
            this.html += "\n";
        }
        MessageBox.Show(this.html);*/
    }
}
