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
        public ActionResult AddTracker(ViewModels.HomeViewModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                PackageService.AddItems(model.ContainerIdentifier,
                                        model.ItemIdentifiers.Where(i => !string.IsNullOrWhiteSpace(i)).ToArray(),
                                        model.ContainerComments);
                model = new ViewModels.HomeViewModel();
                model.Notify("Les objets ont été ajoutés avec succès");
                return View("~/Views/Active/Index.cshtml", model);
            }

            return View("~/Views/Active/Index.cshtml", model);
        }

    }
}