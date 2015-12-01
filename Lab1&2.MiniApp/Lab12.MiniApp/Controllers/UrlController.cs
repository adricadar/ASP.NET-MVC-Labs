using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Lab12.MiniApp.Models;

namespace Lab12.MiniApp.Controllers
{
    public class UrlController : Controller
    {
        public static Dictionary<String, UrlModel> _urls = new Dictionary<string, UrlModel>();

        [HttpGet]
        public ActionResult Shorten()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Shorten(UrlModel urlModel)
        {
            if (ModelState.IsValid && !_urls.ContainsKey(urlModel.Name))
            {
                _urls.Add(urlModel.Name, urlModel);
                return RedirectToAction("Display", new { id = urlModel.Name});
            }
            return View(urlModel);
        }

        public ActionResult Index(string name)
        {
            if (String.IsNullOrEmpty(name) || !_urls.ContainsKey(name))
            {
                return RedirectToAction("Shorten");
            }
            return Redirect(_urls[name].LongUrl);
        }

        public ActionResult Display(string id)
        {
            if (String.IsNullOrEmpty(id) || !_urls.ContainsKey(id))
            {
                return RedirectToAction("Shorten");
            }
            UrlModel urlModel = _urls[id];
            return View(urlModel);
        }
	}
}