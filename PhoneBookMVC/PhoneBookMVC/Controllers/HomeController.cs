using PhoneBookMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace PhoneBookMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return Content("Pierwsza apka");
            //using (DbEntities db = new DbEntities())
            //{
            //    var people = db.People
            //        .Include(a => a.Phone)
            //        .ToList();
            //    return View(people);
            //}
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
    }
}