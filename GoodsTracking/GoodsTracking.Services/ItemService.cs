using GoodsTracking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Services
{
    public class ItemService : ServiceBase
    {
        public void CreateItem(string itemIdentifier, string description)
        {
            using (var unitOfWork = UnitOfWorkFactory.CreateAutoCommit())
            {
                var repository = unitOfWork.GetRepository<Item>();

                if (!repository.Any(i => i.Identifier.Equals(itemIdentifier, StringComparison.InvariantCultureIgnoreCase)))
                {
                    repository.Insert(new Item
                    {
                        Description = description,
                        Identifier = itemIdentifier
                    });
                }
            }
        }
    }
}
