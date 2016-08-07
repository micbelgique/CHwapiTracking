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
                                          .GetAll()
                                          .Where(p => p.Item.Identifier == itemIdentifier)
                                          .OrderByDescending(p => p.In)
                                          .Select(p => p.Container)
                                          .FirstOrDefault();

                var searchResults = unitOfWork.GetRepository<Event>()
                                       .GetMany(e => e.Container.Identifier == container.Identifier, null, "Tracker", "Tracker.Area")
                                       .Select(e => new ItemEventSearchResult
                                       {
                                           ItemIdentifier = itemIdentifier,
                                           Location = e.Tracker.Area.Name,
                                           Time = e.Time
                                       });

                return searchResults;
            }
        }

        public void CreateEvent(int gateId, string containerIdentifier)
        {
            using (IUnitOfWork unitOfWork = UnitOfWorkFactory.CreateAutoCommit())
            {
                var containerRepository = unitOfWork.GetRepository<Container>();
                var trackerRepository = unitOfWork.GetRepository<Tracker>();
                var eventRepository = unitOfWork.GetRepository<Event>();
                Tracker tracker = trackerRepository.GetById(gateId);

                if (tracker != null)
                {
                    Container container = containerRepository.Get(i => i.Identifier.Equals(containerIdentifier, StringComparison.InvariantCultureIgnoreCase));

                    if (container != null)
                    {
                        Event currentEvent = new Event();
                        currentEvent.Container = container;
                        currentEvent.Time = DateTime.Now;
                        currentEvent.Tracker = tracker;

                        eventRepository.Insert(currentEvent);
                    }
                }


            }
        }
    }
}
