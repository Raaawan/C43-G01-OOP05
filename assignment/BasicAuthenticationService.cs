using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        //2-In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.
        //It returns true if the user is authenticated and false otherwise.The AuthorizeUser method checks if the user with the given username has the specified role.
        //It returns true if the user is authorized and false otherwise.
        #region properties
        public readonly string UserNameAdmin = "UserRawan"; 
        public readonly string UserPasswordAdmin = "Rawan";
        public readonly string UserRoleAdmin = "Admin";

        #endregion

        #region methods
        public bool AuthenticateUser(string userName, string password)
        {
            return userName == UserNameAdmin && password == UserPasswordAdmin;
        }

        public bool AuthorizeUser(string userName, string role)
        {
            return userName == UserNameAdmin && role == UserRoleAdmin;
        }
        #endregion
    }
}
