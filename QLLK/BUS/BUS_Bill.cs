using QLLK.DAL;
using QLLK.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLK.BUS
{
    class BUS_Bill
    {
        DAL_Bill dataBill = new DAL_Bill();

        public void ShowDGV(DataGridView dGV, BindingNavigator bN)
        {
            DataTable data = dataBill.Get();
            BindingSource bS = new BindingSource();
            bS.DataSource = data;
            dGV.AutoGenerateColumns = false;
            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }

        public void dropItem(DTO_Bill info)
        {
            string[] value =
            {
                info.Id.ToString()
            };
            dataBill.Delete(value);
        }
    }
}
