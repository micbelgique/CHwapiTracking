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
            var eventService = new EventService();
            var test = eventService.GetAll();

            return View();
        }

        // Add tracker
        public ActionResult AddTracker(ViewModels.HomeViewModel homeViewModel)
        {
            if (ModelState.IsValid)
            {
                bool validationResult = true;
                if (homeViewModel.ItemIdentifier == null || homeViewModel.ItemIdentifier.All(s => string.IsNullOrEmpty(s)))
                {
                    ModelState.AddModelError(nameof(homeViewModel.ItemIdentifier), new ValidationException("One item must be filled"));
                    validationResult = false;

                }

                if (validationResult)
                {
                    ModelState.Clear();
                    return View("~/Views/Home/Index.cshtml");
                }
            }

            return View("~/Views/Home/Index.cshtml", homeViewModel);
        }
    }
}