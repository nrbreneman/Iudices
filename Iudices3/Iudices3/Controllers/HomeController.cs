using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Iudices3.Models;
using Iudices3.DAL;

namespace Iudices3.Controllers
{
    public class HomeController : Controller
    {
        //private JurySQLDAO jurySQLDAO;
        //private IAuthProvider authProvider;

        //public HomeController(IAuthProvider authProvider, JurySQLDAO jurySQLDAO)
        //{
        //    this.jurySQLDAO = jurySQLDAO;
        //    this.authProvider = authProvider;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            NumJuror model = new NumJuror();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(NumJuror model)
        {
            return RedirectToAction("ListPool", model);
        }

        [HttpGet]
        public IActionResult ListPool(NumJuror model)
        {

            int numberOfJurors = model.numberOfJurors;
            JurySQLDAO jurySQLDAO = new JurySQLDAO();
            JuryPool jury = new JuryPool();
            int rows = jurySQLDAO.GetRows();
            RandomID randomID = new RandomID();
            for (int i = 0; i < numberOfJurors; i++)
            {
                Juror juror = new Juror();
                juror = jurySQLDAO.GetJuror(randomID.getRandomID(rows));
                jury.Pool.Add(juror);
            }

            return View(jury);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
