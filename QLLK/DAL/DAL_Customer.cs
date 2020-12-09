using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class DAL_Customer
    {
        Connect connect = new Connect();
        public DataTable Get()
        {
            return connect.Query("SELECT * FROM customer").FetchAll();
        }
        public int InsertID(string[] value)
        {
            return connect.Query("INSERT INTO customer(fullname, phone_number, address) VALUES(?, ?, ?); SELECT SCOPE_IDENTITY()").Value(value).GetID();
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE customer SET fullname = ?, phone_number = ?, address = ? WHERE id = ?").Value(value).Execute();
        }
        public DataRow isCustomer(string[] value)
        {
            return connect.Query("SELECT * FROM customer WHERE fullname = ? AND phone_number = ?").Value(value).Fetch();
        }
    }
}
