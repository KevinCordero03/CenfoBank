using AppCoreLogic;
using DataAccess.Crud;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpPost]
        public APIResponse Create(Customer customer)
        {
            try
            {
                var cm = new CustomerManager();
                cm.Create(customer);
                return new APIResponse()
                {
                    Status = "OK",
                    Message = "Customer created successfully"
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

        }//End Create

        [HttpPut]
        public APIResponse Update(Customer customer)
        {
            try
            {
                var cm = new CustomerManager();
                cm.Update(customer);
                return new APIResponse()
                {
                    Status = "OK",
                    Message = "Customer updated successfully"
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
        }//End Upgrade

        [HttpDelete]
        public APIResponse Delete(Customer customer)
        {
            try
            {
                var cm = new CustomerManager();
                cm.Delete(customer);
                return new APIResponse()
                {
                    Status = "OK",
                    Message = "Customer deleted successfully"
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
        }//End Delete

        [HttpGet]
        public APIResponse RetrieveById(string id)
        {
            try
            {
                var cm = new CustomerManager();
                var customer = cm.RetrieveById(id);

                return new APIResponse()
                {
                    Status = "OK",
                    Data = customer
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
        public APIResponse RetrieveAll()
        {
            try
            {
                var cm = new CustomerManager();
                var lstCustomer = cm.RetrieveAll();

                return new APIResponse()
                {
                    Status = "OK",
                    Data = lstCustomer
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