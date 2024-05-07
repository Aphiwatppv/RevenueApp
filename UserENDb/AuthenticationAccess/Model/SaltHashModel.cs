using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationAccess.Model
{
    public class SaltHashModel
    {
        public string Salt { get; set; }
        public string HashPassword { get; set; }
    }
}
