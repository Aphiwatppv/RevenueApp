
namespace DataAccess.SqlAccess
{
    public interface ISqlAccessInternal
    {
        Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U Parameters);
        Task UpdateAsync<T>(string storedProcedure, T Parameters);
    }
}