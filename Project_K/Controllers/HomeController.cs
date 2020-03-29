using Project_K.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_K.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Vvod()
        {
            
            return View();
        }
        
        public ActionResult Test()
        {
            IEnumerable<Test> tests = db.Tests;
            ViewBag.Tests = tests;

            return View();
        }
        public ActionResult Teoria()
        {

            return View();
        }
        public ActionResult Reg()
        {

            return View();
        }
    }
}