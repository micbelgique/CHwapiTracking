using GoodsTracking.Services;
using GoodsTracking.Web.Payload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoodsTracking.Web.Controllers
{
    public class GoodsTrackingApiController : ApiControllerBase
    {
        public IHttpActionResult CheckPoint(CheckPointData checkPointData)
        {
            EventService eventService = new EventService();
            eventService.CreateEvent(checkPointData.GateID, checkPointData.Message.BoxID);

            return Ok(checkPointData);
        }

    
    }

}
