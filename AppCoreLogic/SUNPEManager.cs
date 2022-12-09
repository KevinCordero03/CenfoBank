using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AppCoreLogic
{
    public class SUNPEManager
    {
        public void SuscribeFintech()
        {
            //Me conecto al banco central de cenfotec y registro esta fintech
            //Request http post al banco central y enviar el suscriptor

            var suscriptor = new Suscriptor()
            {
                BaseURL = "http://kcordero-sinpe.azurewebsites.net",
                Code = "0203",
                Description = "Arbank Los Angeles",
                Name = "ArBank",
                Owner = "Kevin Cordero Arias"
            };

            var URL = "https://sunpe-cenfobank.azurewebsites.net/api/Suscription/Subscribe";
            var client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string jsonObject = JsonConvert.SerializeObject(suscriptor);

            var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
            var result = client.PostAsync(URL, content).Result;

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("Error when process request");
            }

        }

        public List<Suscriptor> RetrieveAllSuscriptor()
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
