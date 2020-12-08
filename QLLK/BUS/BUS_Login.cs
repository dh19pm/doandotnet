using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLK.DAL;
using QLLK.DTO;

namespace QLLK.BUS
{
    class BUS_Login
    {
        DAL_Account dataAccount = new DAL_Account();
        public DataRow getLogin(DTO_Account info)
        {
            string[] value = {
                info.Username,
                info.Password
            };
            return dataAccount.getLogin(value);
        }
    }
}
