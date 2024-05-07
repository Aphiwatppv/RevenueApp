
namespace AuthenticationAccess.SqlAccess
{
    public interface ISqlAccess
    {
        Task<IEnumerable<T>> QueryDataAsync<T, U>(string storedProcedure, U parameter);
        Task<T?> QuerySingleRecordAsync<T, U>(string storedProcedure, U parameter);
    }
}