using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExampleWebAndWin.DatabaseContext.DatabaseContext;
using ExampleWebAndWin.Models.Models;

namespace ExampleWebAndWinApp.Controllers
{
    public class StudentController : Controller
    {
        DatabaseDbContext db = new DatabaseDbContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "StudentId, FirstName, LastName, Email, RollNo, Contact")] Student student)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }

        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        [HttpPost]
        public ActionResult Update(Student student)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            return View();
        }
    }
}