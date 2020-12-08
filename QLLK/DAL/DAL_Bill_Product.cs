using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class DAL_Bill_Product
    {
        Connect connect = new Connect();
        public DataTable Get()
        {
            return connect.Query("SELECT * FROM bill_product").FetchAll();
        }
        public void Insert(string[] value)
        {
            connect.Query("INSERT INTO bill_product(bill_id, product_id) VALUES(?, ?)").Value(value);
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE bill_product SET bill_id = ?, product_id = ? WHERE id = ?").Value(value);
        }
    }
}
