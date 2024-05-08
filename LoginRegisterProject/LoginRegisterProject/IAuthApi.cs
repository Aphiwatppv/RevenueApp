
namespace LoginRegisterProject
{
    public interface IAuthApi
    {
        Task<EmployeeDetail> LoginAsync(EmployeeInput loginRequestModel);
        Task<string> RegisterAsync(EmployeeRegistration registerRequestModel);
    }
}