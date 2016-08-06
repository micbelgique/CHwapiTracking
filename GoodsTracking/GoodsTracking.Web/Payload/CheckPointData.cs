using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodsTracking.Web.Payload
{
    public class CheckPointData
    {
        public int GateID { get; set; }

        public ContainerMessage Message { get; set; }

    }
}