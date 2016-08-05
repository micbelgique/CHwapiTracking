using GoodsTracking.DataAccess;
using GoodsTracking.Interfaces;

namespace GoodTracking.Services
{
    public abstract class ServiceBase
    {
        protected IUnitOfWorkFactory UnitOfWorkFactory => new UnitOfWorkFactory("GoodsTrackingConnectionString");
    }
}