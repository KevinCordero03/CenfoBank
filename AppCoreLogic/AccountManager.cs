using DataAccess.Crud;
using DTO_POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoreLogic
{
    public class AccountManager
    {
        public void Create(Account account)
        {
            var crud = new AccountCrudFactory();
            crud.Create(account);
        }

        public void Update(Account account)
        {
            var am = RetrieveById(account.Id);
            if (am != null)
            {
                var crudFactory = new AccountCrudFactory();
                crudFactory.Update(account);
            }
            else
            {
                throw new Exception("Account doesn't exist. Please verify.");
            }
        }
        public Account RetrieveById(string id)
        {
            var crudFactory = new AccountCrudFactory();
            var account = crudFactory.RetrieveById<Account>(id);
            return account;
        }

        public void Delete(Account account)
        {
            var am = RetrieveById(account.Id);
            if (am != null)
            {
                var crudFactory = new AccountCrudFactory();
                crudFactory.Delete(account);
            }
            else
            {
                throw new Exception("Account doesn't exist. Please verify.");
            }
        }
    }
}
