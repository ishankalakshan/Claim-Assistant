using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class UserLogin_ML
    {
        public string username;
        public string password;

        public string MytEst()
        {
            return username + password;
        }
    }
}
