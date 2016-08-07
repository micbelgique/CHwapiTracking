using GoodsTracking.Domain;

namespace GoodsTracking.Services
{
    public class TrackerService : ServiceBase
    {
        public bool AddItem(int id, int type, int areadId)
        {
            using (var unitOfWork = UnitOfWorkFactory.CreateAutoCommit())
            {
                var trackerRepository = unitOfWork.GetRepository<Tracker>();
                var areaRepository = unitOfWork.GetRepository<Area>();

                var area = areaRepository.GetById(areadId);

                if (!trackerRepository.Any(t => t.Id == id) && area != null)
                {
                    trackerRepository.Insert(new Tracker
                    {
                        Id = id,
                        Type = (TrackerType)type,
                        Area = area                        
                    });
                }

            }

            return true;
        }

    }
}
