using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QLLK.DAL;
using QLLK.DTO;

namespace QLLK.BUS
{
    class BUS_Category
    {
        DAL_Category dataCategory = new DAL_Category();
        public void ShowDGV(DataGridView dGV, BindingNavigator bN, TextBox txtId, TextBox txtName)
        {
            DataTable data = dataCategory.Get();
            BindingSource bS = new BindingSource();
            bS.DataSource = data;

            if (data != null)
            {
                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", bS, "id", false, DataSourceUpdateMode.Never);

                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", bS, "name", false, DataSourceUpdateMode.Never);
            }

            dGV.AutoGenerateColumns = false;
            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }
        public void addItem(DTO_Category info)
        {
            string[] value =
            {
                info.Name
            };
            dataCategory.Insert(value);
        }
        public void editItem(DTO_Category info)
        {
            string[] value =
            {
                info.Name,
                info.Id.ToString()
            };
            dataCategory.Update(value);
        }
        public void dropItem(DTO_Category info)
        {
            string[] value =
            {
                info.Id.ToString()
            };
            dataCategory.Delete(value);
        }
    }
}
