﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BetterEnglishWebApplication123.DAL;
//using BetterEnglishWebApplication123.ViewModels;
using BetterEnglishWebApplication123.ViewModelsFolder;

namespace BetterEnglishWebApplication123.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           IQueryable<EnrollmentDateGroup> data = from student in db.Students
               group student by student.Date into dateGroup
               select new EnrollmentDateGroup()
               {
                   Date = dateGroup.Key,
                   StudentCount = dateGroup.Count()
               };
    return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}