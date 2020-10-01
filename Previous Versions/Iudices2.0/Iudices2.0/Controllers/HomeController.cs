using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iudices2._0.DAL;
using Iudices2._0.Models;
using Iudices2._0.Providers.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Iudices2._0.Controllers
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
            return RedirectToAction("ListPool", model.numberOfJurors);
        }

        [HttpGet]
        public IActionResult ListPool(int numberOfJurors)
        {
            //added temp data to ensure working code 
            //int numberOfJurors = numJuror.numberOfJurors;
            JurySQLDAO jurySQLDAO = new JurySQLDAO();numberOfJurors = 7;
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
    }
}