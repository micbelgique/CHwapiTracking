using GoodsTracking.Services;
using GoodsTracking.Services.DTOs;
using GoodsTracking.Web.ViewModels;
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
            var model = new SearchViewModel();
            model.SearchResults = new List<ItemEventSearchResult>();
            return View(model);
        }

        [HttpPost]
        public ActionResult Search(SearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                var eventService = new EventService();

                var searchResults = eventService.Search(model.ContainerIdentifier);

                model.SearchResults = searchResults;

            }
            return View("Index", model);
        }
    }
}