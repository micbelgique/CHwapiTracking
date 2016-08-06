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
                ModelState.Clear();
                PackageService.RemoveItems(stopTrackingViewModel.ContainerIdentifier,stopTrackingViewModel.ItemIdentifiers);
                return View("~/Views/StopTracking/Index.cshtml");
            }

            return View("~/Views/StopTracking/Index.cshtml", stopTrackingViewModel);
        }
    }
}