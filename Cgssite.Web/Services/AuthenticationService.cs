using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace CgsSite.Web.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public void SignIn(string accountId, string accountName, bool createPersistentCookie)
        {
            FormsAuthentication.SetAuthCookie(accountName, createPersistentCookie);
        }
        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}