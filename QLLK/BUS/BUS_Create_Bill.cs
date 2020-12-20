using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLK.DAL;
using QLLK.DTO;

namespace QLLK.BUS
{
    class BUS_Create_Bill
    {
        DAL_Bill dataBill = new DAL_Bill();
        DAL_Bill_Product dataBillProduct = new DAL_Bill_Product();
        DAL_Product dataProduct = new DAL_Product();
        DAL_Customer dataCustomer = new DAL_Customer();
        int amount = 0;
        public int totalCost(string[] bill)
        {
            int tong = 0;
            string[] word;
            foreach (string str in bill)
            {
                word = str.Split('|');
                string[] value = {word[0]};
                tong += dataProduct.getCost(value) * Convert.ToInt32(word[1]);
                this.amount += Convert.ToInt32(word[1]);
            }
            return tong;
        }
        public void EditAmount(int id, int buy)
        {
            string[] value =
            {
                id.ToString()
            };
            int amount = dataProduct.getAmount(value);
            string[] values =
            {
                (amount - buy).ToString(),
                id.ToString()
            };
            dataProduct.UpdateAmount(values);
        }
        public void addItem(DTO_Customer info, string[] bill, int totalCost)
        {
            string[] valueCustomers = {
                info.Fullname,
                info.PhoneNumber
            };

            int idCustomer;
            DataRow rowCustomer = dataCustomer.isCustomer(valueCustomers);
            if (rowCustomer == null)
            {
                string[] valueCustomer = {
                    info.Fullname,
                    info.PhoneNumber,
                    info.Address
                };
                idCustomer = dataCustomer.InsertID(valueCustomer);
                if (idCustomer <= 0)
                    return;
            }
            else
                idCustomer = Convert.ToInt32(rowCustomer["id"]);

            string timeNow = DateTime.Now.ToString("yyyy-MM-dd");
            string[] valueBill =
            {
                "1",
                idCustomer.ToString(),
                amount.ToString(),
                totalCost.ToString(),
                timeNow
            };
            int idBill = dataBill.InsertID(valueBill);
            if (idBill <= 0)
                return;


            string[] word;
            foreach (string str in bill)
            {
                word = str.Split('|');
                string[] valueBillProduct = {
                    idBill.ToString(),
                    word[0].ToString(),
                    word[1].ToString()
                };
                dataBillProduct.Insert(valueBillProduct);
                EditAmount(Convert.ToInt32(word[0]), Convert.ToInt32(word[1]));
            }

        }
    }

}
