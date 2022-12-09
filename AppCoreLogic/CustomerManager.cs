using DataAccess.Crud;
using DTO_POJOS;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoreLogic
{
    public class CustomerManager
    {

        public void Create(Customer customer)
        {
            //Crea el cliente
            var crudFactory = new CustomerCrudFactory();
            crudFactory.Create(customer);

            //Consultamos el cliente recien creado.
            var c = crudFactory.RetrieveById<Customer>(customer.ID);
            if (c != null)
            {
                var newAccount = new Account()
                {
                    CustomerId = customer.ID,
                    MoneyCode = "CFC",
                    Name = "Cta Apertura",
                    Status = "Active",
                    Id = GetUban()
                };

                var am = new AccountManager();
                am.Create(newAccount);

                var account = am.RetrieveById(newAccount.Id);

                if (account != null)
                {
                    //Envio de correo de bienvenida, indicando informacion de la nueva cuenta.
                    var em = new EmailManager();
                    em.SendWelcomeEmail(customer, account);

                    //Envio de sms de bienvenida
                    var sm = new SMSManager();
                    sm.SendWelcomeSms(customer);
                }
                else
                {
                    throw new Exception("ERROR creating the account.");
                }
            }
            else
            {
                throw new Exception("ERROR creating the customer.");
            }
        }

        private string GetUban()
        {
            //Deberia haber persistencia.
            return getRandomNumberString();
        }

        //////////////////////////////////////////////////////////////////
        public static String getRandomNumberString()
        {
            String startWith = "CR0505-";
            Random generator = new Random();
            String r = generator.Next(0, 999999).ToString("D6");
            String aAccounNumber = startWith + r;
            return aAccounNumber;
        }
        //////////////////////////////////////////////////////////////////


        public void Update(Customer customer)
        {
            var c = RetrieveById(customer.Id);
            if (c != null)
            {
                var crudFactory = new CustomerCrudFactory();
                crudFactory.Update(customer);
            }
            else
            {
                throw new Exception("Customer doesn't exist. Please verify.");
            }
        }
        public Customer RetrieveById(string id)
        {
            var crudFactory = new CustomerCrudFactory();
            var customer = crudFactory.RetrieveById<Customer>(id);//Devuelve un customer
            return customer;
        }
        public void Delete(Customer customer)
        {
            var c = RetrieveById(customer.Id);
            if (c != null)
            {
                var crudFactory = new CustomerCrudFactory();
                crudFactory.Delete(customer);
            }
            else
            {
                throw new Exception("Customer doesn't exist. Please verify.");
            }
        }
        public List<Customer> RetrieveAll()
        {
            var crudFactory = new CustomerCrudFactory();

            var lstCustomers = crudFactory.RetrieveAll<Customer>();

            return lstCustomers;
        }

    }
}
