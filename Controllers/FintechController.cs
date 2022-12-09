using AppCoreLogic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class FintechController : ApiController
    {
        [HttpGet]
        public APIResponse RetrieveAllSuscriptors()
        {
            var sm = new SuscriptorManager();
            var ar = new APIResponse()
            {
                Data = sm.RetrieveAll(),
                Message = "OK",
                Status = "OK"
            };
            return ar;
        }
        [HttpGet]
        public List<Suscriptor> RetrieveSuscriptor()
        {
            var URL = "https://sunpe-cenfobank.azurewebsites.net/api/Suscription/RetrieveAll";
            var lstSuscriptors = new List<Suscriptor>();
            var ar = new APIResponse();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var result = client.GetAsync(URL).Result;

                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync().Result;
                    ar = JsonConvert.DeserializeObject<APIResponse>(response);
                }
                else
                {
                    throw new Exception("Error when process request");
                }

                var jarray = (JArray)ar.Data;

                return jarray.ToObject<List<Suscriptor>>();
            }

        }
    }
}