using AppCoreLogic;
using DTO_POJOS;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class AccountController
    {
        [HttpPost]
        public APIResponse Create(Account account)
        {
            try
            {
                var am = new AccountManager();
                am.Create(account);
                return new APIResponse()
                {
                    Status = "OK",
                    Message = "Account created."
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
        public APIResponse Update(Account account)
        {
            try
            {
                var am = new AccountManager();
                am.Update(account);
                return new APIResponse()
                {
                    Status = "OK",
                    Message = "Account updated."
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
                var am = new AccountManager();
                var account = am.RetrieveById(id);

                return new APIResponse()
                {
                    Status = "OK",
                    Data = account
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
        public APIResponse Delete(Account account)
        {
            try
            {
                var am = new AccountManager();
                am.Delete(account);
                return new APIResponse()
                {
                    Status = "OK",
                    Message = "Account deleted."
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