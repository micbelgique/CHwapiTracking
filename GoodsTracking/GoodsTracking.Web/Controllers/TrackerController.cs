using GoodsTracking.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public class TrackerController : WebControllerBase
    {
        // GET: Tracker
        public ActionResult Index()
        {
            return View("~/Views/Tracker/Index.cshtml", BuildTrackerViewModel());
        }


        // Add tracker
        public ActionResult AddTracker(TrackerViewModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                TrackerService.AddItem(model.Id.Value,
                                        model.TrackerType,
                                        model.AreaId);
                model = BuildTrackerViewModel();
                model.Notify("Le portique a été ajouté avec succès");
            }

            return View("~/Views/Tracker/Index.cshtml", model);
        }

        private TrackerViewModel BuildTrackerViewModel()
        {
            TrackerViewModel model = new TrackerViewModel();
            List<SelectListItem> areas = AreaService.GetAreas().Select(a =>
            {
                return new SelectListItem { Text = a.Name, Value = a.Id.ToString() };

            }).ToList();
            model.Areas = new SelectList(areas, nameof(SelectListItem.Value), nameof(SelectListItem.Text));

            return model;
        }
    }
}