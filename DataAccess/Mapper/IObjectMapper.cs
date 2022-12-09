using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    interface IObjectMapper
    {
        BaseEntity BuildObject(Dictionary<string, object> row);

        List<BaseEntity> BuildObject(List<Dictionary<string, object>> lstRows);
    }
}
