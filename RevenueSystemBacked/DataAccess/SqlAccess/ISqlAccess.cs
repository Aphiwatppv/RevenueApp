
namespace DataAccess.SqlAccess
{
    /// <summary>
    /// Interface defining the contract for SQL data access operations.
    /// </summary>
    public interface ISqlAccess
    {
        /// <summary>
        /// Retrieves data asynchronously from the database using a stored procedure and parameters.
        /// </summary>
        /// <typeparam name="T">The type of data to return.</typeparam>
        /// <typeparam name="U">The type of parameters used in the stored procedure.</typeparam>
        /// <param name="storedProcedure">The name of the stored procedure to execute.</param>
        /// <param name="parameters">The parameters required for the stored procedure.</param>
        /// <returns>A task that represents the asynchronous operation, containing an enumerable list of data type T.</returns>
        Task<IEnumerable<T>> GetDataAsync<T, U>(string storedProcedure, U parameters);

        /// <summary>
        /// Executes a stored procedure to update data asynchronously in the database.
        /// </summary>
        /// <typeparam name="T">The type of parameters used in the stored procedure.</typeparam>
        /// <param name="storedProcedure">The name of the stored procedure to execute.</param>
        /// <param name="parameters">The parameters required for the stored procedure.</param>
        /// <returns>A task representing the asynchronous operation of the update.</returns>
        Task UpdateAsync<T>(string storedProcedure, T parameters);
    }
}