using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DTO
{
    class DTO_Product
    {
        private int id;
        DTO_Account account = new DTO_Account();
        DTO_Category category = new DTO_Category();
        DTO_Producer producer = new DTO_Producer();
        DTO_Import import = new DTO_Import();
        DTO_Origin origin = new DTO_Origin();
        private string name;
        private int amount;
        private int price;
        private int warrantyPeriod;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Price { get => price; set => price = value; }
        public int WarrantyPeriod { get => warrantyPeriod; set => warrantyPeriod = value; }
        internal DTO_Account Account { get => account; set => account = value; }
        internal DTO_Category Category { get => category; set => category = value; }
        internal DTO_Producer Producer { get => producer; set => producer = value; }
        internal DTO_Import Import { get => import; set => import = value; }
        internal DTO_Origin Origin { get => origin; set => origin = value; }
    }
}
