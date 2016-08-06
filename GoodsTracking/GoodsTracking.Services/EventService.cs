using GoodsTracking.Domain;
using GoodsTracking.Interfaces;
using GoodsTracking.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Services
{
    public class EventService : ServiceBase
    {
        public IEnumerable<ItemEventSearchResult> Search(string itemIdentifier)
        {
            using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
            {
                var container = unitOfWork.GetRepository<Package>()
                                          .GetMany(p => p.Item.Identifier.Equals(itemIdentifier, StringComparison.InvariantCultureIgnoreCase)
                                                     && p.Out == null)
                                          .OrderByDescending(p => p.In)
                                          .Select(p => p.Container)
                                          .FirstOrDefault();

                var searchResults = unitOfWork.GetRepository<Event>()
                                       .GetMany(e => e.Container == container)
                                       .Select(e => new ItemEventSearchResult
                                       {
                                           ItemIdentifier = itemIdentifier,
                                           Location = e.Tracker.Area.Name,
                                           Time = e.Time
                                       });

                return searchResults;
            }
        }

        public void CreateEvent()
        {

        }
    }
}
