using GoodsTracking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Services
{
    public class PackageService : ServiceBase
    {
        //public bool CreatePackage(string containerIdentifier, string comment, out int packageId)
        //{
        //    using (var unitOfWork = UnitOfWorkFactory.CreateAutoCommit())
        //    {
        //        var packageRepository = unitOfWork.GetRepository<Package>();
        //        if (packageRepository.Any(p=>p.Container.Identifier == containerIdentifier))
        //        {
        //            packageId = 0;
        //            return false;
        //        }

        //        var containerRepository = unitOfWork.GetRepository<Container>();
        //        Container container = containerRepository.Get(c => c.Identifier == containerIdentifier);

        //        if (container != null)
        //        {
        //            packageRepository.Insert(new Package
        //            {
        //                Comment = comment,
        //                Container = container,

        //            })
        //        }
        //    }
        //}

        public bool AddItems(string containerIdentifier, string[] itemIdentifiers, string comment)
        {
            using (var unitOfWork = UnitOfWorkFactory.CreateAutoCommit())
            {
                var containerRepository = unitOfWork.GetRepository<Container>();
                var itemRepository = unitOfWork.GetRepository<Item>();

                if (!containerRepository.Any(c=>c.Identifier == containerIdentifier))
                {
                    containerRepository.Insert(new Container
                    {
                        Identifier = containerIdentifier,
                        Type = ContainerType.Normal
                    });
                }
                foreach (string itemIdentifier in itemIdentifiers)
                {
                    if (!itemRepository.Any(i=>i.Identifier == itemIdentifier))
                    {
                        itemRepository.Insert(new Item
                        {
                            Identifier = itemIdentifier
                        });
                    }
                }
            }

            using (var unitOfWork = UnitOfWorkFactory.CreateAutoCommit())
            {
                var containerRepository = unitOfWork.GetRepository<Container>();
                var itemRepository = unitOfWork.GetRepository<Item>();

                var container = containerRepository.Get(c => c.Identifier == containerIdentifier);
                foreach (string itemIdentifier in itemIdentifiers)
                {
                    var item = itemRepository.Get(i => i.Identifier == itemIdentifier);
                    unitOfWork.GetRepository<Package>().Insert(new Package
                    {
                        Comment = comment,
                        Container = container,
                        In = DateTime.Now,
                        Item = item
                    });
                    return true;
                }
            }
            return true;
        }

        public bool RemoveItem(string containerIdentifier, string itemIdentifier)
        {
            using (var unitOfWork = UnitOfWorkFactory.CreateAutoCommit())
            {

            }
            return true;
        }
    }
}
