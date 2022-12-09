using DataAccess.DAO;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public interface ICrudStatements
    {
        SqlOperation GetCreateStatement(BaseEntity entityPojo);
        SqlOperation GetUpdateStatement(BaseEntity entityPojo);
        SqlOperation GetDeleteStatement(BaseEntity entityPojo);
        SqlOperation GetRetrieveByIdStatement(string id);
    }
}
