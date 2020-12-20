using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLLK.DAL
{
    class DAL_Export_Bill
    {
        Connect connect = new Connect();
        public DataRow getBill(string[] value)
        {
            return connect.Query("SELECT b.*, a.fullname account, c.fullname customer FROM (bill b INNER JOIN account a ON b.account_id = a.id) INNER JOIN customer c ON b.customer_id = c.id WHERE b.id = ?").Value(value).Fetch();
        }
        public DataTable getProduct(string[] value)
        {
            return connect.Query("SELECT * FROM bill_product b INNER JOIN product p ON b.product_id = p.id WHERE bill_id = ?").Value(value).FetchAll();
        }
    }
}
