using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthAccess.Model
{
    public class ReturnLoginModel
    {
        public int? Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ReturnLoginModel()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            RoleName = string.Empty;
        }
    }
}
