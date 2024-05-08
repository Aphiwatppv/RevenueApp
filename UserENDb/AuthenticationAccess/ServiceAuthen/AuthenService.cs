using AuthenticationAccess.EncryptSecurity;
using AuthenticationAccess.Model;
using AuthenticationAccess.SqlAccess;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace AuthenticationAccess.ServiceAuthen
{
    public class AuthenService : IAuthenService
    {
        private readonly ISqlAccess _sqlAccess;

        public AuthenService(ISqlAccess sqlAccess)
        {
            _sqlAccess = sqlAccess;

        }



        private bool IsValidPassword(string password, string salt, string hash)
        {
            return EncryptPassword.VerifyPassword(password, salt, hash);
        }

        public async Task<string?> Register(EmployeeRegistration employeeRegistration)
        {
            var SaltHash = EncryptPassword.HashPassword(employeeRegistration.Password);
            var EncryptInput = new EncryptEmployeeRegistration
            {
                EN = employeeRegistration.EN,
                Name = employeeRegistration.Name,
                RoleId = 99,
                HashPassword = SaltHash.HashPassword,
                Salt = SaltHash.Salt
            };

            var result = await _sqlAccess.QuerySingleRecordAsync<string, dynamic>(storedProcedure: "dbo.spRegisterEmployee", new
            {
                EN = EncryptInput.EN,
                Name = EncryptInput.Name,
                Salt = EncryptInput.Salt,
                HashPassword = EncryptInput.HashPassword,
                RoleId = EncryptInput.RoleId
            });

            return result;
        }

        public async Task<EmployeeDetail> Login(EmployeeInput employeeInput)
        {

            var getsalthash = await _sqlAccess.QuerySingleRecordAsync<SaltHashModel, dynamic>(storedProcedure: "dbo.spGetSaltHash", new
            {
                EN = employeeInput.EN
            });

            if (!string.IsNullOrEmpty(getsalthash?.Salt) && !string.IsNullOrEmpty(getsalthash.HashPassword))
            {
                if (IsValidPassword(employeeInput.Password, getsalthash.Salt, getsalthash.HashPassword))
                {
                    var result = await _sqlAccess.QuerySingleRecordAsync<EmployeeDetail, dynamic>(storedProcedure: "dbo.spGetEmployeeDetail", new
                    {
                        EN = employeeInput.EN
                    });
                    return result;
                }
                else
                {
                    return new EmployeeDetail { Name = $"Can't Encrypt password Salt | {getsalthash?.Salt} Hash | {getsalthash?.HashPassword}" };
                }

            }
            return new EmployeeDetail
            {
                Name = $"Salt or Hash are empty Salt | {getsalthash?.Salt} Hash | {getsalthash?.HashPassword};"
            };


        }

        public async Task<IEnumerable<EmployeeDetail>> GetAllUser()
        {
            var result = await _sqlAccess.QueryDataAsync<EmployeeDetail, dynamic>(storedProcedure: "dbo.spGetAllEmployeeDetail", new { });

            return result;
        }



    }
}


