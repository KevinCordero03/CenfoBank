using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO_DTOs
{
    public class Customer : BaseEntity
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}
