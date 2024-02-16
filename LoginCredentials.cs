using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Jenkins
{
    public class LoginCredentials
    {
        public string Authenticate(string userName, string password)
        {
            string msg;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                msg = "User name and password required";

            }
            else
            {
                if (userName == "admin" && password == "admin@123")
                {
                    msg = "Authentication Pass";

                }
                else
                {
                    msg = "Authentication fail";
                }
            }
            return msg;
        }
    }
}
