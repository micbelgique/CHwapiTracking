using GoodsTracking.Domain;
using GoodsTracking.Services.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace GoodsTracking.Services
{
    public class AreaService : ServiceBase
    {
        public AreaItem[] GetAreas()
        {
            using (var unitOfWork = UnitOfWorkFactory.CreateAutoCommit())
            {
                var areaRepository = unitOfWork.GetRepository<Area>();

                var areas = areaRepository.GetAll();

                if (areas != null)
                {
                    return areas.Select(a =>
                    {
                        return new AreaItem()
                        {
                            // TODO Why long
                            Id = (int)a.Id,
                            Description = a.Description,
                            Name = a.Name

                        };
                    }).ToArray();
                }

            }

            return null;
        }

    }
}
