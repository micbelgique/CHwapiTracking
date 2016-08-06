using GoodsTracking.Domain;
using GoodsTracking.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Services
{
    public class EventService : ServiceBase
    {
        public IEnumerable<Event> GetAll()
        {
            using (IUnitOfWork unitOfWork = UnitOfWorkFactory.Create())
            {
                return unitOfWork.GetRepository<Event>().GetAll();
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
