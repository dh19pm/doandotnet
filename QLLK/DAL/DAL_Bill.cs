using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class DAL_Bill
    {
        Connect connect = new Connect();
        public DataTable Get()
        {
            return connect.Query("SELECT * FROM bill").FetchAll();
        }
        public int InsertID(string[] value)
        {
            return connect.Query("INSERT INTO bill(account_id, customer_id, amount, price, create_date) VALUES(?, ?, ?, ?, ?); SELECT SCOPE_IDENTITY()").Value(value).GetID();
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE bill SET account_id = ?, customer_id = ?, amount = ?, price = ?, create_date = ? WHERE id = ?").Value(value).Execute();
        }
    }
}
