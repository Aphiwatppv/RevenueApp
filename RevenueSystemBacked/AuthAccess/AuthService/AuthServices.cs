using AuthAccess.Model;
using AuthAccess.SqlAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AuthAccess.SecurityLogic;
using System.Data.SqlClient;
using System.Data;
using static Dapper.SqlMapper;
namespace AuthAccess.AuthService
{
    public class AuthServices : IAuthServices
    {
        private readonly ISqlAccess _sqlAccess;

        public AuthServices(ISqlAccess sqlAccess)
        {
            _sqlAccess = sqlAccess;
        }
        private async Task<ReturnHashSalt> GetHashSaltAsync(UserInput userInput)
        {
            var result = await _sqlAccess.GetOneRecordAsync<ReturnHashSalt, dynamic>("dbo.spGetSaltHash",
                new
                {
                    Email = userInput.Email
                });

            return result ?? new ReturnHashSalt();
        }
        private bool IsValidPassword(string password, string salt, string hash)
        {
            return EncryptPassword.VerifyPassword(password, salt, hash);
        }
        public async Task<ReturnLoginModel> LoginMethodAsync(UserInput userInput)
        {
            var hashSalt = await GetHashSaltAsync(userInput);
            var Isvalid = IsValidPassword(userInput.Password, hashSalt.Salt, hashSalt.HashPassword);
            if (!string.IsNullOrWhiteSpace(hashSalt?.Salt) && !string.IsNullOrWhiteSpace(hashSalt?.HashPassword))
            {
               
                if (IsValidPassword(userInput.Password, hashSalt.Salt, hashSalt.HashPassword))
                {
                    var result = await _sqlAccess.GetOneRecordAsync<ReturnLoginModel, dynamic>("dbo.spLogin", new
                    {
                        Email = userInput.Email,
                        HashPassword = hashSalt.HashPassword
                    });

                    return result ?? new ReturnLoginModel
                    {
                        Email = "Invalid Pass"
                    };
                }
            }
            else
            {
                // Handle the case where either the salt or hash password is null or white space
                return new ReturnLoginModel { Email = "Invalid Salt or Hash Password" };
            }

            return new ReturnLoginModel { Email = $" Salt : {hashSalt?.Salt}  Hash : {hashSalt?.HashPassword} {Isvalid}" };
        }


        public async Task<string> RegisterMethod(RegisteringModel model)
        {
            var hashPass = EncryptPassword.HashPassword(model.Password);

            var parameters = new
            {
                model.FirstName,
                model.LastName,
                model.Email,
                model.IdentityID,
                hashPass.HashPassword,
                hashPass.Salt,
            };


            string result = await _sqlAccess.UpdateAsyncWithReturning<dynamic>(
                storedProcedure: "dbo.spRegisterUser", parameters: parameters);

            ResultModel.ResultInformation = result;

            return result;
        }


    }
}
