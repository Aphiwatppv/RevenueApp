using AuthAccess.Model;

namespace AuthAccess.AuthService
{
    public interface IAuthServices
    {
        Task<ReturnLoginModel> LoginMethodAsync(UserInput userInput);
        Task<StatusCodeRegistering> RegisterUserAsync(RegisteringUserInput newUser, string password);
    }
}