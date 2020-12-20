using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DAL
{
    class DAL_Revenue
    {
        Connect connect = new Connect();
        public int getRevenue(string[] value)
        {
            DataRow row = connect.Query("SELECT SUM(price) result FROM bill WHERE create_date >= ? AND create_date <= ?").Value(value).Fetch();
            if (row != null && !(row["result"] is DBNull))
                return Convert.ToInt32(row["result"]);
            return 0;
        }
    }
}
