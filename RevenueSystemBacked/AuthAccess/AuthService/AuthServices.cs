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

            if (!string.IsNullOrWhiteSpace(hashSalt?.Salt) && !string.IsNullOrWhiteSpace(hashSalt?.HashPassword))
            {
                if (IsValidPassword(userInput.Password, hashSalt.Salt, hashSalt.HashPassword))
                {
                    var result = await _sqlAccess.GetOneRecordAsync<ReturnLoginModel, dynamic>("dbo.spLogin", new
                    {
                        Email = userInput.Email,
                        HashPassword = hashSalt.HashPassword
                    });

                    return result ?? new ReturnLoginModel();
                }
            }

            return new ReturnLoginModel();
        }

        public async Task<StatusCodeRegistering> RegisterUserAsync(RegisteringUserInput newUser, string password)
        {
            var hashpass = EncryptPassword.HashPassword(password);

            var model = new RegisteringModel
            {
               
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Email = newUser.Email,
                IdentityID = newUser.IdentityID,
                Salt = hashpass.Salt,
                HashPassword = hashpass.HashPassword

            };

            var result = await _sqlAccess.UpdateAsyncSignleRecord<StatusCodeRegistering, dynamic>(storedProcedures: "dbo.spRegisterUser", new
            {

                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                IdentityID = model.IdentityID,
                HashPassword = model.HashPassword,
                Salt = model.Salt



            });

            return result;
        }


    }
}
