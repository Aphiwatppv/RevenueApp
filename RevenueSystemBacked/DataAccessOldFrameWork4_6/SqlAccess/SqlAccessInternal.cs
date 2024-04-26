using Dapper; // V1.6
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccessOldFrameWork4_6.SqlAccess
{
    public class SqlAccessInternal
    {
        private readonly string _connectionstring;

        public SqlAccessInternal(string connectionstring)
        {
            _connectionstring = connectionstring;
        }


        public async Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U Parameters)
        {
            using (IDbConnection connection = new SqlConnection(_connectionstring))
            {
                return await connection.QueryAsync<T>(storedProcedure, Parameters, commandType: CommandType.StoredProcedure);
            }

        }


        public async Task UpdateAsync<T>(string storedProcedure, T Parameters)
        {
            using (IDbConnection connection = new SqlConnection(_connectionstring))
            {
                await connection.ExecuteAsync(storedProcedure, Parameters, commandType: CommandType.StoredProcedure);
            }

        }
    }
}
