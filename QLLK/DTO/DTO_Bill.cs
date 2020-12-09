using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DTO
{
    class DTO_Bill
    {
        private int id;
        DTO_Account account = new DTO_Account();
        DTO_Customer customer = new DTO_Customer();
        private int amount;
        private int price;
        private DateTime createDate;
        public int Id { get => id; set => id = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Price { get => price; set => price = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        internal DTO_Account Account { get => account; set => account = value; }
        internal DTO_Customer Customer { get => customer; set => customer = value; }
    }
}
