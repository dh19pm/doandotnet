using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLK.DAL;
using QLLK.DTO;
using System.Windows.Forms;
using System.Data;

namespace QLLK.BUS
{
    class BUS_Producer
    {
        DAL_Producer dataProducer = new DAL_Producer();
        public void ShowDGV(DataGridView dGV, BindingNavigator bN, TextBox txtId, TextBox txtName)
        {
            DataTable data = dataProducer.Get();
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
        public void addItem(DTO_Producer info)
        {
            string[] value =
            {
                info.Name
            };
            dataProducer.Insert(value);
        }
        public void editItem(DTO_Producer info)
        {
            string[] value =
            {
                info.Name,
                info.Id.ToString()
            };
            dataProducer.Update(value);
        }
        public void dropItem(DTO_Producer info)
        {
            string[] value =
            {
                info.Id.ToString()
            };
            dataProducer.Delete(value);
        }
    }
}
