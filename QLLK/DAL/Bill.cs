using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class Bill
    {
        Connect connect = new Connect();
        public Bill()
        {

        }
        public DataTable Get()
        {
            return connect.Query("SELECT * FROM BILL").Fetch();
        }
        public void Insert(string[] value)
        {
            connect.Query("INSERT INTO BILL(AMOUNT, PRICE, CREATE_DATE) VALUES(?, ?, ?)").Value(value);
        }
        public void Update(string[] value)
        {
            //dsadas
            connect.Query("UPDATE BILL SET AMOUNT = ?, PRICE = ?, CREATE_DATE = ? WHERE ID = ?").Value(value);
        }
    }
}
