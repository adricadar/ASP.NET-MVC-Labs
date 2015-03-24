using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCoolApplication.Models;

namespace MyCoolApplication.Controllers
{
public class FacultyController : Controller
{
    // GET
    public ActionResult Index()
    {
        var faculty = new Faculty
        {
            TeachersCount = 2,
            StudentsCount = 10,
            Name = "AC"
        };

        return View(faculty);
    }
}
}