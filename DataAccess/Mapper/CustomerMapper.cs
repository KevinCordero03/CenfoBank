using DataAccess.DAO;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class CustomerMapper : EntityMapper, ICrudStatements, IObjectMapper
    {
        public SqlOperation GetCreateStatement(BaseEntity entityPojo)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CUSTOMER_PR" };

            var customer = (Customer)entityPojo;
            operation.AddVarcharParam("ID", customer.ID);
            operation.AddVarcharParam("NAME", customer.Name);
            operation.AddVarcharParam("LASTNAME", customer.LastName);
            operation.AddVarcharParam("email", customer.email);
            operation.AddVarcharParam("phone", customer.phone);
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entityPojo)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CUSTOMER_PR" };

            var customer = (Customer)entityPojo;
            operation.AddVarcharParam("ID", customer.Id);
            operation.AddVarcharParam("NAME", customer.Name);
            operation.AddVarcharParam("LASTNAME", customer.LastName);
            operation.AddVarcharParam("email", customer.email);
            operation.AddVarcharParam("phone", customer.phone);
            return operation;

        }

        public SqlOperation GetDeleteStatement(BaseEntity entityPojo)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CUSTOMER_PR" };

            var customer = (Customer)entityPojo;
            operation.AddVarcharParam("ID", customer.Id);
            operation.AddVarcharParam("NAME", customer.Name);
            operation.AddVarcharParam("LASTNAME", customer.LastName);
            operation.AddVarcharParam("email", customer.email);
            operation.AddVarcharParam("phone", customer.phone);
            return operation;
        }

        public SqlOperation GetRetrieveByIdStatement(string id)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_CUSTOMER_BY_ID_PR"
            };

            operation.AddVarcharParam("ID", id);

            return operation;
        }//En GetDeleteStatement


        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var customer = new Customer
            {
                Id = row["Id"].ToString(),
                Name = row["Name"].ToString(),
                LastName = row["LastName"].ToString()
            };

            return customer;
        }//End BuildObject

        public List<BaseEntity> BuildObject(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var customer = BuildObject(row);
                lstResults.Add(customer);
            }

            return lstResults;
        }
        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "RET_ALL_CUSTOMERS_PR"
            };


            return operation;
        }
    }
}
