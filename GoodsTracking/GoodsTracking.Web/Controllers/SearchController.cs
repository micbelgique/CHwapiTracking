using GoodsTracking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public class SearchController : WebControllerBase
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public dynamic Search(string identifier)
        {
            var eventService = new EventService();

            var searchResults =  eventService.Search(identifier);

            return new
            {
                data = searchResults.ToArray()
            };
        }
    }
}