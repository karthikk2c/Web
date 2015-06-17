﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RamsWebApplication.Models;

namespace RamsWebApplication.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult RAMSManagement()
        {
             RamsEntities db = new RamsEntities();
            var r=db.rams.ToList();
            return View(r);
        }
    }
}
