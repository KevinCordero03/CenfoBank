using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoreLogic
{
    public class SuscriptorManager
    {
        public List<Suscriptor> RetrieveAll()
        {
            var lst = new List<Suscriptor>();

            var s = new Suscriptor();

            lst.Add(s);
            return lst;
        }
    }
}
