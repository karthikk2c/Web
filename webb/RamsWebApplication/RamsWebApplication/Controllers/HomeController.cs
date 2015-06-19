using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RamsWebApplication.Models;

namespace RamsWebApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        RamsEntities db = new RamsEntities();
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template by karthik";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "this is git practise.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult RAMSManagement(string sortOrder)
        {
            ViewBag.DateSortParm = sortOrder == "Date" ? "Date_desc" : "Date";
            var r = from s in db.rams
                    select s;
            switch (sortOrder)
            {
                case "Date_desc":
                    r = r.OrderByDescending(s => s.DAteOfSurvey);
                    break;
                default:
                    r = r.OrderBy(s => s.DAteOfSurvey);
                    break;
            }
            return View(r.ToList());
        }
    }
}
