using AuthAccess.Model;

namespace AuthAccess.AuthService
{
    public interface IAuthServices
    {
        Task<ReturnLoginModel> LoginMethodAsync(UserInput userInput);
        Task<string> RegisterMethod(RegisteringModel model);
    }
}