﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // GET: Store/Product
        public ActionResult Product(string ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View();
        }
    }
}