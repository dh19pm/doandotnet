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
    class BUS_Product
    {
        DAL_Product dataProduct = new DAL_Product();
        DAL_Category dataCategory = new DAL_Category();
        DAL_Producer dataProducer = new DAL_Producer();
        DAL_Origin dataOrigin = new DAL_Origin();
        DAL_Import dataImport = new DAL_Import();
        public void ShowDGV(DataGridView dGV,
                            BindingNavigator bN,
                            ComboBox cboCategory,
                            ComboBox cboProducer,
                            ComboBox cboOrigin,
                            TextBox txtId,
                            TextBox txtName,
                            TextBox txtAmount,
                            TextBox txtPrice,
                            TextBox txtWarrantyDate,
                            ToolStripTextBox txtSearch)
        {
            string[] value = { txtSearch.Text };
            DataTable dataSource = (txtSearch.Text == "" ? dataProduct.Get() : dataProduct.Search(value));

            BindingSource bS = new BindingSource();
            if (dataSource == null)
            {
                bS.DataSource = null;
                dGV.DataSource = bS;
                bN.BindingSource = bS;
            }
            else
            {
                bS.DataSource = dataSource;

                cboCategory.DataBindings.Clear();
                cboCategory.DataBindings.Add("SelectedValue", bS, "category_id", false, DataSourceUpdateMode.Never);

                cboProducer.DataBindings.Clear();
                cboProducer.DataBindings.Add("SelectedValue", bS, "producer_id", false, DataSourceUpdateMode.Never);

                cboOrigin.DataBindings.Clear();
                cboOrigin.DataBindings.Add("SelectedValue", bS, "origin_id", false, DataSourceUpdateMode.Never);

                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", bS, "id", false, DataSourceUpdateMode.Never);

                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", bS, "name", false, DataSourceUpdateMode.Never);

                txtAmount.DataBindings.Clear();
                txtAmount.DataBindings.Add("Text", bS, "amount", false, DataSourceUpdateMode.Never);

                txtPrice.DataBindings.Clear();
                txtPrice.DataBindings.Add("Text", bS, "price", false, DataSourceUpdateMode.Never);

                txtWarrantyDate.DataBindings.Clear();
                txtWarrantyDate.DataBindings.Add("Text", bS, "warranty_period", false, DataSourceUpdateMode.Never);

                dGV.AutoGenerateColumns = false;
                dGV.DataSource = bS;
                bN.BindingSource = bS;

                foreach (DataGridViewRow row in dGV.Rows)
                {
                    row.Cells["colChecked"].Value = 0;
                    row.Cells["colAmountBuy"].Value = 0;
                }

            }
        }

        public void ShowCBB(ComboBox cboCategory, ComboBox cboProducer, ComboBox cboOrigin)
        {
            cboCategory.DataSource = dataCategory.Get();
            cboCategory.ValueMember = "id";
            cboCategory.DisplayMember = "name";

            cboProducer.DataSource = dataProducer.Get();
            cboProducer.ValueMember = "id";
            cboProducer.DisplayMember = "name";

            cboOrigin.DataSource = dataOrigin.Get();
            cboOrigin.ValueMember = "id";
            cboOrigin.DisplayMember = "name";
        }
        public void addItem(DTO_Product info)
        {
            string timeNow = DateTime.Now.ToString("yyyy-MM-dd");
            string[] val =
            {
                timeNow
            };
            DataRow getImport = dataImport.getDate(val);
            if (getImport == null)
                info.Import.Id = dataImport.InsertID(val);
            else
                info.Import.Id = Convert.ToInt32(getImport["id"]);
            string[] value = {
                info.Account.Id.ToString(),
                info.Category.Id.ToString(),
                info.Producer.Id.ToString(),
                info.Import.Id.ToString(),
                info.Origin.Id.ToString(),
                info.Name,
                info.Amount.ToString(),
                info.Price.ToString(),
                info.WarrantyPeriod.ToString()
            };
            dataProduct.Insert(value);
        }
        public void editItem(int id, DTO_Product info)
        {
            string[] value = {
                info.Category.Id.ToString(),
                info.Producer.Id.ToString(),
                info.Origin.Id.ToString(),
                info.Name,
                info.Amount.ToString(),
                info.Price.ToString(),
                info.WarrantyPeriod.ToString(),
                id.ToString()
            };
            dataProduct.Update(value);
        }
        public void dropItem(int id)
        {
            string[] value = {
                id.ToString()
            };
            dataProduct.Delete(value);
        }
    }
}
