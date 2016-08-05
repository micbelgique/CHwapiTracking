using GoodsTracking.Services;
using System;
using System.Collections.Generic;
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
            var eventService = new EventService();
            var test = eventService.GetAll();

            return View();
        }
    }
}