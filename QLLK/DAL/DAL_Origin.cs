using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class DAL_Origin
    {
        Connect connect = new Connect();
        public DataTable Get()
        {
            return connect.Query("SELECT * FROM origin").FetchAll();
        }
        public void Insert(string[] value)
        {
            connect.Query("INSERT INTO origin(name) VALUES(?)").Value(value).Execute();
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE origin SET name = ? WHERE id = ?").Value(value).Execute();
        }
    }
}
