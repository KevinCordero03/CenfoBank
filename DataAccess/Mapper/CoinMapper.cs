using DataAccess.DAO;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class CoinMapper : EntityMapper, ICrudStatements
    {
        public SqlOperation GetCreateStatement(BaseEntity entityPojo)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_COIN_PR",
            };

            var coin = (Coin)entityPojo;
            operation.AddVarcharParam("ID", coin.ID);
            operation.AddVarcharParam("NAME", coin.Name);
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entityPojo)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPD_COIN_PR",
            };
            var coin = (Coin)entityPojo;
            operation.AddVarcharParam("ID", coin.Id);
            operation.AddVarcharParam("NAME", coin.Name);
            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entityPojo)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_COIN_PR",
            };
            var coin = (Coin)entityPojo;
            operation.AddVarcharParam("ID", coin.Id);
            operation.AddVarcharParam("NAME", coin.Name);
            return operation;
        }
        public SqlOperation GetRetrieveByIdStatement(string id)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_COIN_BY_ID_PR"
            };
            operation.AddVarcharParam("ID", id);
            return operation;
        }

        ////////////////////////////////////////////////////////////////////////

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var coin = new Coin
            {

                Id = row["Id"].ToString(),
                Name = row["Name"].ToString(),
            };
            return coin;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var coin = BuildObject(row);
                lstResults.Add(coin);
            }
            return lstResults;
        }
    }
}
