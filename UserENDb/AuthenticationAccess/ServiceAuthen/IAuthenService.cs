using AuthenticationAccess.Model;

namespace AuthenticationAccess.ServiceAuthen
{
    public interface IAuthenService
    {
        Task<IEnumerable<EmployeeDetail>> GetAllUser();
        Task<EmployeeDetail> Login(EmployeeInput employeeInput);
        Task<string?> Register(EmployeeRegistration employeeRegistration);
    }
}