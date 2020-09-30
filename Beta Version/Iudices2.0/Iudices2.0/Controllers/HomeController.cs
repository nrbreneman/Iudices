using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Iudices2._0.DAL;
using Iudices2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace Iudices2._0.Controllers
{
    public class HomeController : Controller
    {
        //private JurySQLDAO jurySQLDAO; figure out why this isnt working 

            [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(int number)
        {
           return RedirectToAction("ListPool", number);
        }

        [HttpGet]
        public IActionResult ListPool(int numberOfJurors)
        {
            //added temp data to ensure working code numberOfJurors = 7; 
            //int numberOfJurors = numJuror.numberOfJurors;
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
    }
}