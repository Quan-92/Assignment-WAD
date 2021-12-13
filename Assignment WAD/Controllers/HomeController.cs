using Assignment_WAD.Data;
using Assignment_WAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_WAD.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext myDBContext = new MyDBContext();
        public ActionResult Index()
        {
            
            return View(myDBContext.StudentsLates.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Store(StudentsLate studentLate)
        {
            if (ModelState.IsValid)
            {
                myDBContext.StudentsLates.Add(studentLate);
                myDBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}