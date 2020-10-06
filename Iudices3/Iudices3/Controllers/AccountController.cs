using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iudices3.DAL;
using Iudices3.Models;
using Iudices3.Models.Account;
using Iudices3.Providers.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Iudices3.Controllers
{
    public class AccountController : Controller
    {
        //private IAuthProvider authProvider;
        //private readonly UserSQLDAO userSQLDAO;

        //public AccountController(IAuthProvider authProvider, UserSQLDAO userSQLDAO)
        //{
        //    this.authProvider = authProvider;
        //    this.userSQLDAO = userSQLDAO;
        //}
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Login(LoginViewModel loginViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        bool validLogin = authProvider.SignIn(loginViewModel.Email, loginViewModel.Password);
        //        User user = authProvider.GetCurrentUser();
        //        if (validLogin)
        //        {
        //            if (user.Role == "Admin")
        //            {
        //                return RedirectToAction("Index", "Admin");
        //                //Admin login: admin@gmail.com, Password
        //            }
        //            else
        //            {
        //                return RedirectToAction("GetNumber", "User");
        //            }
        //        }
        //    }

        //    ModelState.AddModelError("password", "Username and/or Password incorrect. Please try again");
        //    return View(loginViewModel); ;
        //}

        [AuthorizationFilter("User")]
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [AuthorizationFilter("User")]
        [HttpPost]
        public IActionResult Update(User user)
        {
            return View();
        }
    }
}