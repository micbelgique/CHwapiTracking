using GoodsTracking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public class HomeController : WebControllerBase
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


    }
}