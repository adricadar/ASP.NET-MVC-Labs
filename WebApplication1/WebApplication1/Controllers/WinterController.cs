using System;
using System.Linq;
using System.Web.Mvc;
using Lab2.Web.Models;

namespace Lab2.Web.Controllers
{
    [Authorize]
    public class WinterController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(WinterModel winterModel)
        {
            if (ModelState.IsValid)
            {
                //save to database
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessages = ModelState.Values
                .Select(x =>
                {
                    if (x.Errors.Count > 0)
                        return x.Errors.FirstOrDefault().ErrorMessage;
                    return String.Empty;
                }).ToList();
            return View(winterModel);
        }
    }
}