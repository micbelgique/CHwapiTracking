using GoodsTracking.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public class ContainerController : WebControllerBase
    {
        // GET: Tracker
        public ActionResult Index()
        {
            return View();
        }


        // Add tracker
        public ActionResult AddContainer(ContainerViewModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                ContainerService.AddItem(model.Identifier,model.Description);
                return Index();
            }

            return View("~/Views/Tracker/Index.cshtml", model);
        }
    }
}