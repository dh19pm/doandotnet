using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLK.DAL;

namespace QLLK.BUS
{
    class BUS_Export_Bill
    {
        DAL_Export_Bill dataExportBill = new DAL_Export_Bill();
        public DataRow getBill(int id)
        {
            string[] value =
            {
                id.ToString()
            };
            return dataExportBill.getBill(value);
        }
        public DataTable getProduct(int id)
        {
            string[] value =
            {
                id.ToString()
            };
            return dataExportBill.getProduct(value);
        }
    }
}
