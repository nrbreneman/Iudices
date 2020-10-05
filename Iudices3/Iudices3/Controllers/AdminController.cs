using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iudices3.Models;
using Iudices3.Providers.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Iudices3.Controllers
{
    public class AdminController : Controller
    {
        [AuthorizationFilter("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpGet]
        public IActionResult CreateAdmin()
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpPost]
        public IActionResult CreateAdmin(User user)
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpGet]
        public IActionResult CreateJuror()
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpPost]
        public IActionResult CreateJuror(Juror juror)
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpGet]
        public IActionResult DeleteJuror()
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpPost]
        public IActionResult DeleteJuror(Juror juror)
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpGet]
        public IActionResult UpdateJuror()
        {
            return View();
        }

        [AuthorizationFilter("Admin")]
        [HttpPost]
        public IActionResult UpdateJuror(Juror juror)
        {
            return View();
        }
    }
}