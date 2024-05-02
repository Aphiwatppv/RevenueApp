using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlAccess
{
    public class SqlAccess : ISqlAccess
    {
        // Configuration interface to access application settings
        private readonly IConfiguration _iconfig;

        // Constructor to inject the configuration
        public SqlAccess(IConfiguration iconfig)
        {
            _iconfig = iconfig;
        }

        /// <summary>
        /// Retrieves data asynchronously from the database using a stored procedure and parameters.
        /// </summary>
        /// <typeparam name="T">The type of data to return.</typeparam>
        /// <typeparam name="U">The type of parameters used in the stored procedure.</typeparam>
        /// <param name="storedProcedure">The name of the stored procedure to execute.</param>
        /// <param name="parameters">The parameters required for the stored procedure.</param>
        /// <returns>An enumerable list of data type T.</returns>
        public async Task<IEnumerable<T>> GetDataAsync<T, U>(string storedProcedure, U parameters)
        {
            // Obtain the connection string from the configuration; throws if not found
            string? connectionString = _iconfig.GetConnectionString("Default");
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // Execute the stored procedure asynchronously and return the results
                return await connection.QueryAsync<T>(storedProcedure, parameters);
            }
        }

        /// <summary>
        /// Executes a stored procedure to update data asynchronously in the database.
        /// </summary>
        /// <typeparam name="T">The type of parameters used in the stored procedure.</typeparam>
        /// <param name="storedProcedure">The name of the stored procedure to execute.</param>
        /// <param name="parameters">The parameters required for the stored procedure.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task UpdateAsync<T>(string storedProcedure, T parameters)
        {
            // Obtain the connection string from the configuration; throws if not found
            string? connectionString = _iconfig.GetConnectionString("Default");
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                // Execute the stored procedure asynchronously without expecting any return value
                await connection.ExecuteAsync(storedProcedure, parameters);
            }
        }
    }
}
