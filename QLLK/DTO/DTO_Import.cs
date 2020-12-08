using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLK.DTO
{
    class DTO_Import
    {
        private int id;
        private DateTime createDate;
        public int Id { get => id; set => id = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
    }
}
