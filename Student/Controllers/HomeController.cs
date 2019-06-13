using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student.Controllers
{
    public class HomeController : Controller
    {
        StudentsEntities db = new StudentsEntities();
        public ActionResult Index()
        {
            ViewBag.allStudents = db.Users.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                ViewBag.activeStudent = db.Users.FirstOrDefault(st => st.id == id);
            }
            else
            {
                ViewBag.Error = "Bele telebe yoxdur";
            }
            return View();
        }
    
    }
}