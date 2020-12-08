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
        public void Insert(string[] value)
        {
            connect.Query("INSERT INTO bill(customer_id, amount, price, create_date) VALUES(?, ?, ?, ?)").Value(value);
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE bill SET customer_id = ?, amount = ?, price = ?, create_date = ? WHERE id = ?").Value(value);
        }
    }
}
