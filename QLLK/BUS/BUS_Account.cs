using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLK.DAL;
using System.Windows.Forms;
using QLLK.DTO;
using System.Data;

namespace QLLK.BUS
{
    class BUS_Account
    {
        DAL_Account dataAccount = new DAL_Account();
        public void ShowDGV(DataGridView dGV, BindingNavigator bN, TextBox txtId, TextBox txtFullname, TextBox txtName, TextBox txtPass, ComboBox cboPosition)
        {
            DataTable data = dataAccount.Get();
            BindingSource bS = new BindingSource();
            bS.DataSource = data;

            if(data != null)
            {
                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", bS, "id", false, DataSourceUpdateMode.Never);

                txtFullname.DataBindings.Clear();
                txtFullname.DataBindings.Add("Text", bS, "fullname", false, DataSourceUpdateMode.Never);

                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", bS, "username", false, DataSourceUpdateMode.Never);

                txtPass.DataBindings.Clear();
                txtPass.DataBindings.Add("Text", bS, "password", false, DataSourceUpdateMode.Never);

                cboPosition.DataBindings.Clear();
                cboPosition.DataBindings.Add("SelectedValue", bS, "position", false, DataSourceUpdateMode.Never);
            }

            dGV.AutoGenerateColumns = false;
            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }
        
        public void addItem(DTO_Account info)
        {
            string timeNow = DateTime.Now.ToString("yyyy-MM-dd");
            string[] value =
            {
                info.Position.ToString(),
                info.Fullname,
                info.Username,
                info.Password, 
                timeNow
            };
            dataAccount.Insert(value);
        }
        public void editItem(DTO_Account info)
        {
            string[] value =
            {
                info.Position.ToString(),
                info.Fullname,
                info.Username,
                info.Password,
                info.Id.ToString()
            };
            dataAccount.Update(value);
        }
        public void dropItem(DTO_Account info)
        {
            string[] value =
            {
                info.Id.ToString()
            };
            dataAccount.Delete(value);
        }
    }
}
