using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodsTracking.Web.ViewModels
{
    public class StopTrackingViewModel
    {
        public string ContainerIdentifier { get; set; }

        public string[] ItemIdentifier { get; set; }
    }
}