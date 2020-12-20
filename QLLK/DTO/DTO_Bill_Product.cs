using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DTO
{
    class DTO_Bill_Product
    {
        private int id;
        DTO_Bill bill = new DTO_Bill();
        DTO_Product product = new DTO_Product();
        public int Id { get => id; set => id = value; }
        internal DTO_Bill Bill { get => bill; set => bill = value; }
        internal DTO_Product Product { get => product; set => product = value; }
    }
}