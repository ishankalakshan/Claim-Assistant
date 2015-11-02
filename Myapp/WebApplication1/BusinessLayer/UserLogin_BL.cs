using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BusinessLayer
{
    public class UserLogin_BL
    {
        public bool UserAuthentication(UserLogin_ML ml)
        {
            try
            {
                return new userLogin().authenticate(ml);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string UserAuthentication_App(UserLogin_ML ml)
        {
            try
            {
                return new userLogin().authenticate_app(ml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
