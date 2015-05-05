using Cgssite.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cgssite.Web.Models;
using System.Web.Security;

namespace Cgssite.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthenticationService _authenticationservice;
        public AccountController(IAuthenticationService authenticationservice)
        {
            this._authenticationservice = authenticationservice;
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel loginModel, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if(!FormsAuthentication.Authenticate(loginModel.AccountName,loginModel.Password))
            {
                ModelState.AddModelError("login", "用户名或密码不正确");
                return View();
            }
            _authenticationservice.SignIn("1",loginModel.AccountName,loginModel.RememberMe);
            if (!string.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Admin");
            }
        }
        [Authorize]
        public ActionResult Logout()
        {
            _authenticationservice.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}