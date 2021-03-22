﻿using Smartphones.Domain.Contracs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISmartphonesServices _smartphonesServices;


        public HomeController(ISmartphonesServices smartphonesServices)
        {
            _smartphonesServices = smartphonesServices;
        }

        public ActionResult Index()
        {
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