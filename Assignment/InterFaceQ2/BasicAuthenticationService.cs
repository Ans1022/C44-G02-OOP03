using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterFaceQ2
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private string storedUsername = "Anas";
        private string storedPassword = "1234";
        private string storedRole = "Four";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
}
