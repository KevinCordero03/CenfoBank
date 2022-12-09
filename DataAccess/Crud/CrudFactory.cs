using DataAccess.DAO;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Crud
{
    public abstract class CrudFactory
    {
        //SQL
        protected SqlDao dao;

        public abstract void Create(BaseEntity entityPojo);

        public abstract void Update(BaseEntity entityPojo);

        public abstract void Delete(BaseEntity entityPojo);

        public abstract T RetrieveById<T>(string id);

        public abstract List<T> RetrieveAll<T>();
    }
}
