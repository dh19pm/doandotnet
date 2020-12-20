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
            return connect.Query("SELECT b.*, c.fullname customer, a.fullname account FROM (bill b INNER JOIN customer c ON b.customer_id = c.id) INNER JOIN account a ON b.account_id = a.id").FetchAll();
        }
        public int InsertID(string[] value)
        {
            return connect.Query("INSERT INTO bill(account_id, customer_id, amount, price, create_date) VALUES(?, ?, ?, ?, ?); SELECT SCOPE_IDENTITY()").Value(value).GetID();
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE bill SET account_id = ?, customer_id = ?, amount = ?, price = ?, create_date = ? WHERE id = ?").Value(value).Execute();
        }
        public void Delete(string[] value)
        {
            connect.Query("DELETE FROM bill WHERE id = ?").Value(value).Execute();
        }
    }
}
