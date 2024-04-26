using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccess.SqlAccess
{
    public class SqlAccessInternal : ISqlAccessInternal
    {
        private readonly string _connectionstring;

        public SqlAccessInternal(string connectionstring)
        {
            _connectionstring = connectionstring;
        }


        public async Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U Parameters)
        {
            using IDbConnection connection = new SqlConnection(_connectionstring);
            return await connection.QueryAsync<T>(storedProcedure, Parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task UpdateAsync<T>(string storedProcedure, T Parameters)
        {

            using IDbConnection connection = new SqlConnection(_connectionstring);
            await connection.ExecuteAsync(storedProcedure, Parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
