using AppCoreLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class InitController : ApiController
    {
        public string Init()
        {
            var sm = new SUNPEManager();
            sm.SuscribeFintech();

            return "Ok";
        }
    }
}