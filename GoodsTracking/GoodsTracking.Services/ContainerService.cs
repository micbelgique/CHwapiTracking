using GoodsTracking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Services
{
    public class ContainerService : ServiceBase
    {
        public bool AddItem(string identifier, string description)
        {
            using (var unitOfWork = UnitOfWorkFactory.CreateAutoCommit())
            {
                var containerRepository = unitOfWork.GetRepository<Container>();

                if (!containerRepository.Any(c=>c.Identifier == identifier))
                {
                    containerRepository.Insert(new Container
                    {
                        Identifier = identifier,
                        Type = ContainerType.Normal,
                        Description = description
                    });
                }
            }

            return true;
        }
    }
}
