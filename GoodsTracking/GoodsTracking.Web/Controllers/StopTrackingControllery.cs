using GoodsTracking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public class StopTrackingController : WebControllerBase
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Add tracker
        public ActionResult StopTracker(ViewModels.StopTrackingViewModel stopTrackingViewModel)
        {
            if (ModelState.IsValid)
            {
                bool validationResult = true;
                if (stopTrackingViewModel.ItemIdentifier == null || stopTrackingViewModel.ItemIdentifier.All(s => string.IsNullOrEmpty(s)))
                {
                    ModelState.AddModelError(nameof(stopTrackingViewModel.ItemIdentifier), new ValidationException("One item must be filled"));
                    validationResult = false;

                }

                if (validationResult)
                {
                    ModelState.Clear();
                    return View("~/Views/StopTracking/Index.cshtml");
                }
            }

            return View("~/Views/StopTracking/Index.cshtml", stopTrackingViewModel);
        }
    }
}