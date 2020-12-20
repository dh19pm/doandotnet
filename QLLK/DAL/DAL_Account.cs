using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class DAL_Account
    {
        Connect connect = new Connect();
        public DataTable Get()
        {
            return connect.Query("SELECT * FROM account").FetchAll();
        }
        public void Insert(string[] value)
        {
            connect.Query("INSERT INTO account(position, fullname, username, password, create_date) VALUES(?, ?, ?, ?, ?)").Value(value).Execute();
        }
        public void Update(string[] value)
        {
            connect.Query("UPDATE account SET position = ?, fullname = ?, username = ?, password = ? WHERE id = ?").Value(value).Execute();
        }
        public void Delete(string[] value)
        {
            connect.Query("DELETE FROM account WHERE id = ?").Value(value).Execute();
        }
        public DataRow getLogin(string[] value)
        {
            return connect.Query("SELECT * FROM account WHERE username = ? AND password = ?").Value(value).Fetch();
        }
    }
}
