using GoodsTracking.Domain;
using GoodsTracking.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodTracking.Services
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
    }
}
