using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLK.DAL;
using QLLK.DTO;

namespace QLLK.BUS
{
    class BUS_Customer
    {
        DAL_Customer dataCustomer = new DAL_Customer();
        public void ShowDGV(DataGridView dGV, BindingNavigator bN, TextBox txtId, TextBox txtFullname, TextBox txtPhonenumber, TextBox txtAddress)
        {
            DataTable data = dataCustomer.Get();
            BindingSource bS = new BindingSource();
            bS.DataSource = data;
            if (data != null)
            {
                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", bS, "id", false, DataSourceUpdateMode.Never);

                txtFullname.DataBindings.Clear();
                txtFullname.DataBindings.Add("Text", bS, "fullname", false, DataSourceUpdateMode.Never);

                txtPhonenumber.DataBindings.Clear();
                txtPhonenumber.DataBindings.Add("Text", bS, "phone_number", false, DataSourceUpdateMode.Never);

                txtAddress.DataBindings.Clear();
                txtAddress.DataBindings.Add("Text", bS, "address", false, DataSourceUpdateMode.Never);
            }
            dGV.AutoGenerateColumns = false;
            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }
        public void editItem(DTO_Customer info)
        {
            string[] value =
            {
                info.Fullname,
                info.PhoneNumber,
                info.Address,
                info.Id.ToString()
            };
            dataCustomer.Update(value);
        }
        public void dropItem(DTO_Customer info)
        {
            string[] value =
            {
                info.Id.ToString()
            };
            dataCustomer.Delete(value);
        }
    }
}
