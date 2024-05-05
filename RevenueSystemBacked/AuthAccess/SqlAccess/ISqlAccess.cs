
namespace AuthAccess.SqlAccess
{
    public interface ISqlAccess
    {
        Task<IEnumerable<T>> GetDataAsync<T, U>(string storedProcedure, U parameters);
        Task<T?> GetOneRecordAsync<T, U>(string storedprocedures, U parameters);
        Task UpdateAsync<T>(string storedProcedure, T parameters);
        Task<T> UpdateAsyncSignleRecord<T, U>(string storedProcedures, U parameters);
        Task<int> UpdateAsyncWithReturning<U>(string storedProcedure, U parameters);
    }
}