using AppCoreLogic;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class CoinController : APIResponse
    {
        [HttpPost]
        public APIResponse Create(Coin coin)
        {
            try
            {
                var cm = new CoinManager();
                cm.Create(coin);
                return new APIResponse()
                {
                    Status = "OK",
                    Message = "Coin created."
                };
            }
            catch (Exception ex)
            {
                return new APIResponse()
                {
                    Status = "ERROR",
                    Message = ex.Message
                };
            }
        }

        [HttpPut]
        public APIResponse Update(Coin coin)
        {
            try
            {
                var cm = new CoinManager();
                cm.Update(coin);
                return new APIResponse()
                {
                    Status = "OK",
                    Message = "Coin updated."
                };
            }
            catch (Exception ex)
            {
                return new APIResponse()
                {
                    Status = "ERROR",
                    Message = ex.Message
                };
            }
        }

        [HttpGet]
        public APIResponse RetrieveById(string id)
        {
            try
            {
                var cm = new CoinManager();
                var coin = cm.RetrieveById(id);

                return new APIResponse()
                {
                    Status = "OK",
                    Data = coin
                };
            }
            catch (Exception ex)
            {
                return new APIResponse()
                {
                    Status = "ERROR",
                    Message = ex.Message
                };
            }
        }
        [HttpDelete]
        public APIResponse Delete(Coin coin)
        {
            try
            {
                var cm = new CoinManager();
                cm.Delete(coin);
                return new APIResponse()
                {
                    Status = "OK",
                    Message = "Coin deleted."
                };
            }
            catch (Exception ex)
            {
                return new APIResponse()
                {
                    Status = "ERROR",
                    Message = ex.Message
                };
            }
        }
    }
}