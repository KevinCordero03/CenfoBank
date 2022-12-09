using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class StatusController : ApiController
    {
        [HttpGet]
        public string HealthCheck()
        {
            return "The api is running today at " + DateTime.Now.ToString();
        }
    }
}