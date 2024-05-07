using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AuthenticationAccess.SqlAccess
{
    public class SqlAccess : ISqlAccess
    {
        private readonly IConfiguration _configuration;

        public SqlAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<T?> QuerySingleRecordAsync<T, U>(string storedProcedure, U parameter)
        {
            string? connectionstring = _configuration.GetConnectionString("Default");
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                var result = await connection.QueryFirstOrDefaultAsync<T>(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }

        }

        public async Task<IEnumerable<T>> QueryDataAsync<T, U>(string storedProcedure, U parameter)
        {
            string? connectionstring = _configuration.GetConnectionString("Default");
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                var result = await connection.QueryAsync<T>(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }


    }
}
