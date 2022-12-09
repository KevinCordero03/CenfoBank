using DataAccess.DAO;
using DataAccess.Mapper;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Crud
{
    public class CoinCrudFactory : CrudFactory
    {
        private CoinMapper mapper;
        public CoinCrudFactory() : base()
        {
            mapper = new CoinMapper();
            dao = SqlDao.GetInstance();
        }
        public override void Create(BaseEntity entityPojo)
        {
            var coin = (Coin)entityPojo;
            var sqlOperation = mapper.GetCreateStatement(coin);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Update(BaseEntity entityPojo)
        {
            var coin = (Coin)entityPojo;
            var sqlOperation = mapper.GetUpdateStatement(coin);
            dao.ExecuteProcedure(sqlOperation);
        }
        public override void Delete(BaseEntity entityPojo)
        {
            var coin = (Coin)entityPojo;
            var sqlOperation = mapper.GetDeleteStatement(coin);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override T RetrieveById<T>(string id)
        {
            var lstResults = dao.ExecuteQueryProcedure(mapper.GetRetrieveByIdStatement(id));

            var dic = new Dictionary<string, object>();

            if (lstResults.Count > 0)
            {
                dic = lstResults[0];
                var objPojo = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objPojo, typeof(T));
            }
            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }
    }
}
