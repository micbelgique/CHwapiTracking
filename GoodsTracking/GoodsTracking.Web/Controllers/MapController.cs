using GoodsTracking.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public class MapController : WebControllerBase
    {
        // GET: Tracker
        public ActionResult Index()
        {


            return View("~/Content/Map/Index.cshtml");
        }


    }
}