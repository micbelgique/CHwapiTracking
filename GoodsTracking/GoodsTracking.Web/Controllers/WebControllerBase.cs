using GoodsTracking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.Controllers
{
    public abstract class WebControllerBase : Controller
    {
        protected PackageService PackageService => new PackageService();
        protected TrackerService TrackerService => new TrackerService();
        protected AreaService AreaService => new AreaService();
    }
}