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
    public class CustomerCrudFactory : CrudFactory
    {
        private CustomerMapper mapper;
        public CustomerCrudFactory() : base()
        {
            mapper = new CustomerMapper();
            dao = SqlDao.GetInstance();
        }
        public override void Create(BaseEntity entityPojo)
        {
            var customer = (Customer)entityPojo;

            var sqlOperation = mapper.GetCreateStatement(customer);

            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Update(BaseEntity entityPojo)
        {
            var customer = (Customer)entityPojo;
            var sqlOperation = mapper.GetUpdateStatement(customer);
            dao.ExecuteProcedure(sqlOperation);

        }//End Update

        public override void Delete(BaseEntity entityPojo)
        {
            var customer = (Customer)entityPojo;
            var sqlOperation = mapper.GetDeleteStatement(customer);
            dao.ExecuteProcedure(sqlOperation);
        }//End Delete

        public override T RetrieveById<T>(string id)
        {
            var lstResults = dao.ExecuteQueryProcedure(mapper.GetRetrieveByIdStatement(id));

            var dic = new Dictionary<string, object>();

            if (lstResults.Count > 0)
            {
                dic = lstResults[0];
                var objPojo = mapper.BuildObject(dic);
                //Convierte en un CUSTOMER
                return (T)Convert.ChangeType(objPojo, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var list = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());

            var dic = new Dictionary<string, object>();

            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObject(lstResult);
                foreach (var c in objs)
                {
                    list.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return list;
        }
    }
}

