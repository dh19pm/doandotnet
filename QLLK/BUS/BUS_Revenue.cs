using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLK.BUS;
using QLLK.DAL;

namespace QLLK.BUS
{
    class BUS_Revenue
    {
        DAL_Revenue dataRevenue = new DAL_Revenue();
        public int getRevenue(DateTime dtpBegin, DateTime dtpEnd)
        {
            string[] value =
            {
                dtpBegin.ToString("yyyy-MM-dd"),
                dtpEnd.ToString("yyyy-MM-dd")
            };
            return dataRevenue.getRevenue(value);
        }
    }
}
