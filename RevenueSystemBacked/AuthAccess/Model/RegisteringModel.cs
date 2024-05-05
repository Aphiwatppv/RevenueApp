using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthAccess.Model
{
    public class RegisteringModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IdentityID { get; set; }
        public string HashPassword { get; set; }
        public string Salt { get; set; }
    }
}
