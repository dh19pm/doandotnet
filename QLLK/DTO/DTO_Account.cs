using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DTO
{
    class DTO_Account
    {
        private int id;
        private int position;
        private string username;
        private string password;
        private DateTime createDate;
        public int Id { get => id; set => id = value; }
        public int Position { get => position; set => position = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
    }
}
