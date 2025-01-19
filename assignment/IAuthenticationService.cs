using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal interface IAuthenticationService
    {
        //1-We start by defining the IAuthenticationService interface with two methods:
        //AuthenticateUser and AuthorizeUser.The BasicAuthenticationService class implements this interface and
        //provides the specific implementation for these methods.
        #region Methods
        public bool AuthenticateUser(string userName, string password);
        public bool AuthorizeUser(string userName , string role);
        #endregion
    }
}
