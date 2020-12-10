using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class DAL_Category
    {
        Connect connect = new Connect();
        public DataTable Get()
        {
            return connect.Query("SELECT * FROM category").FetchAll();
        }
        public void Insert(string[] value)
        {
            connect.Query("INSERT INTO category(name) VALUES(?)").Value(value).Execute();
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE category SET name = ?  WHERE id = ?").Value(value).Execute();
        }
        public void Delete(string[] value)
        {
            connect.Query("DELETE FROM category WHERE id = ?").Value(value).Execute();
        }
    }
}