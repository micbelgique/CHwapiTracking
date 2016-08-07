﻿using GoodsTracking.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public class ItemController : WebControllerBase
    {
        // GET: Tracker
        public ActionResult Index()
        {
            return View();
        }


        // Add tracker
        public ActionResult AddItem(ItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                ItemService.CreateItem(model.Identifier,model.Description);
                return View("~/Views/Item/Index.cshtml");
            }

            return View("~/Views/Item/Index.cshtml", model);
        }
    }
}