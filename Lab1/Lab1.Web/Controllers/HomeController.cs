using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(); // by default action name -> Index
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact"); // explicitly render view Contact
        }
    }
}