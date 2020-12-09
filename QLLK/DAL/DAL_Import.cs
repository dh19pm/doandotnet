using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class DAL_Import
    {
        Connect connect = new Connect();
        public DataTable Get()
        {
            return connect.Query("SELECT * FROM import").FetchAll();
        }
        public void Insert(string[] value)
        {
            connect.Query("INSERT INTO import(create_date) VALUES(?)").Value(value).Execute();
        }
        public int InsertID(string[] value)
        {
            return connect.Query("INSERT INTO import(create_date) VALUES(?); SELECT SCOPE_IDENTITY()").Value(value).GetID();
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE import SET create_date = ? WHERE id = ?").Value(value).Execute();
        }
        public DataRow getDate(string[] value)
        {
            return connect.Query("SELECT * FROM import WHERE create_date = ?").Value(value).Fetch();
        }
    }
}
