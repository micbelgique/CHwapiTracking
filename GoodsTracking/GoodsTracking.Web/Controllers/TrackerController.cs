﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public class TrackerController : Controller
    {
        // GET: Tracker
        public ActionResult Index()
        {
            return View(new TrackerViewModel());
        }
    }
}