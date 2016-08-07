using GoodsTracking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public class ActiveController : WebControllerBase
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Add tracker
        public ActionResult AddTracker(ViewModels.HomeViewModel homeViewModel)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                PackageService.AddItems(homeViewModel.ContainerIdentifier,
                                        homeViewModel.ItemIdentifiers.Where(i => !string.IsNullOrWhiteSpace(i)).ToArray(),
                                        homeViewModel.ContainerComments);
                return View("~/Views/Active/Index.cshtml");
            }

            return View("~/Views/Active/Index.cshtml", homeViewModel);
        }

    }
}