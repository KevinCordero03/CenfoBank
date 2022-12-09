using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class SqlOperation
    {
        public string ProcedureName { get; set; }
        public List<SqlParameter> Parameters { get; set; }

        public SqlOperation()
        {
            Parameters = new List<SqlParameter>();
        }

        public void AddVarcharParam(string parameterName, object parameterValue)
        {
            Parameters.Add(new SqlParameter("@P_" + parameterName, parameterValue));
        }
    }
}
