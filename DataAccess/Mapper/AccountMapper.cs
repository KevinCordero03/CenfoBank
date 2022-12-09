using DataAccess.DAO;
using DTO_POJOS;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    internal class AccountMapper : EntityMapper, ICrudStatements
    {
        public SqlOperation GetCreateStatement(BaseEntity entityPojo)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRE_ACCOUNT_PR",
            };
            var account = (Account)entityPojo;
            operation.AddVarcharParam("ID", account.Id);
            operation.AddVarcharParam("NAME", account.Name);
            operation.AddVarcharParam("STATUS", account.Status);
            operation.AddVarcharParam("MONEY_CODE", account.MoneyCode);
            operation.AddVarcharParam("CUSTOMER_ID", account.CustomerId);
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entityPojo)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "UPD_ACCOUNT_PR",
            };
            var account = (Account)entityPojo;
            operation.AddVarcharParam("ID", account.Id);
            operation.AddVarcharParam("NAME", account.Name);
            operation.AddVarcharParam("STATUS", account.Status);
            operation.AddVarcharParam("MONEY_CODE", account.MoneyCode);
            operation.AddVarcharParam("CUSTOMER_ID", account.CustomerId);
            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entityPojo)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "DEL_ACCOUNT_PR",
            };
            var account = (Account)entityPojo;
            operation.AddVarcharParam("ID", account.Id);
            operation.AddVarcharParam("NAME", account.Name);
            operation.AddVarcharParam("STATUS", account.Status);
            operation.AddVarcharParam("MONEY_CODE", account.MoneyCode);
            operation.AddVarcharParam("CUSTOMER_ID", account.CustomerId);
            return operation;
        }

        public SqlOperation GetRetrieveByIdStatement(string id)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ACCOUNT_BY_ID_PR"
            };
            operation.AddVarcharParam("ID", id);

            return operation;
        }


        ////////////////////////////////////////////////////////////////////////
        //Recibir Objetos desde BD SQL a C#

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var account = new Account()
            {
                UBAN = row["UBAN"].ToString(),
                Name = row["Name"].ToString(),
                Status = row["Status"].ToString(),
                MoneyCode = row["MoneyCode"].ToString(),
                CustomerId = row["CustomerID"].ToString(),
            };
            return account;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var account = BuildObject(row);
                lstResults.Add(account);
            }
            return lstResults;
        }
    }
}
