using GoodsTracking.DataAccess;
using GoodsTracking.Interfaces;

namespace GoodsTracking.Services
{
    public abstract class ServiceBase
    {
        protected IUnitOfWorkFactory UnitOfWorkFactory => new UnitOfWorkFactory("GoodsTrackingConnectionString");
    }
}