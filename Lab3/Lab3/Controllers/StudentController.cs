using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class StudentController : Controller
    {
        private SutdentContext _sutdentContext;

        public StudentController()
        {
            _sutdentContext = new SutdentContext();
        }

        public ActionResult Index()
        {
            List<StudentModel> students = _sutdentContext.Students.ToList();
            return View(students);
        }

        //
        // GET: /Student/
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentModel student)
        {
            if (ModelState.IsValid)
            {
                _sutdentContext.Students.Add(student);
                _sutdentContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
	}
}