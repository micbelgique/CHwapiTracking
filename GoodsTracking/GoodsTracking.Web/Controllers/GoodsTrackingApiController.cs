using GoodsTracking.Services;
using GoodsTracking.Services.DTOs;
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

        [HttpGet]
        public IHttpActionResult Search(string identifier)
        {
            var eventService = new EventService();

            var searchResults = eventService.Search(identifier);

            searchResults = new List<ItemEventSearchResult>
            {
                 new ItemEventSearchResult { ItemIdentifier = "1111", Location= "Salle 1", Time = DateTime.Now }
            };

            return Json(searchResults.ToArray());
        }
    }

}
