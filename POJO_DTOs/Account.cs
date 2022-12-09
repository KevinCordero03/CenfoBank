using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_POJOS
{
    public class Account : BaseEntity
    {
        public string CustomerId { get; set; }
        public string UBAN { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string MoneyCode { get; set; }

    }//
}//