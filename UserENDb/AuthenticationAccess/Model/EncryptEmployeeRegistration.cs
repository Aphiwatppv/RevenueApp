using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationAccess.Model
{
    public class EncryptEmployeeRegistration
    {
        public string EN { get; set; }
        public string Name { get; set; }
        public string Salt { get; set; }
        public string HashPassword { get; set; }
        public int RoleId { get; set; } = 99; // Default value set to 99
    }
}
