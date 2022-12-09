using DataAccess.Crud;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCoreLogic
{
    public class CoinManager
    {
        public void Create(Coin coin)
        {
            var crudFactory = new CoinCrudFactory();
            crudFactory.Create(coin);
        }

        public void Update(Coin coin)
        {
            var c = RetrieveById(coin.Id);
            if (c != null)
            {
                var crudFactory = new CoinCrudFactory();
                crudFactory.Update(coin);
            }
            else
            {
                throw new Exception("Coin doesn't exist. Please verify.");
            }
        }

        public Coin RetrieveById(string id)
        {
            var crudFactory = new CoinCrudFactory();
            var coin = crudFactory.RetrieveById<Coin>(id);
            return coin;
        }

        public void Delete(Coin coin)
        {
            var c = RetrieveById(coin.Id);
            if (c != null)
            {
                var crudFactory = new CoinCrudFactory();
                crudFactory.Delete(coin);
            }
            else
            {
                throw new Exception("Coin doesn't exist. Please verify.");
            }
        }
    }
}
