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
        public void Insert(string[] value)
        {
            connect.Query("INSERT INTO customer(fullname, phone_number, address) VALUES(?, ?, ?)").Value(value);
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE customer SET fullname = ?, phone_number = ?, address = ? WHERE id = ?").Value(value);
        }
    }
}
