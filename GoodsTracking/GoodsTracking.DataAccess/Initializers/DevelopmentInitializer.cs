using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GoodsTracking.Domain;

namespace GoodsTracking.DataAccess.Initializers
{
    public class DevelopmentInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    //public class DevelopmentInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            //Creation Block in DB : Areas
            var areas = new List<Area>
            {
                new Area { Id = 0, Name = "Unité de soins 1", Created = DateTime.Now, Description = "Unité de soins 1" },
                new Area { Id = 1, Name = "Unité de soins 2", Created = DateTime.Now, Description = "Unité de soins 2" },
                new Area { Id = 2, Name = "Unité de soins 3", Created = DateTime.Now, Description = "Unité de soins 3" },
                new Area { Id = 3, Name = "Laboratoire de biologie clinique", Created = DateTime.Now, Description = "Laboratoire de biologie clinique"},
                new Area { Id = 4, Name = "Bloc opératoire", Created = DateTime.Now, Description = "Bloc opératoire"},
                new Area { Id = 5, Name = "Service de stérilisation", Created = DateTime.Now, Description = "Service de stérilisation"},
                new Area { Id = 6, Name = "Dépôt 1", Created = DateTime.Now, Description = "Dépôt 1"},
                new Area { Id = 7, Name = "Dépôt 2", Created = DateTime.Now, Description = "Dépôt 2"},
                new Area { Id = 8, Name = "Dépôt 3", Created = DateTime.Now, Description = "Dépôt 3"}
            };

            context.Areas.AddRange(areas);

            //Creation Block in DB : Trackers
            var trackers = new List<Tracker>
            {
                new Tracker { Id = 0, Area = areas[0], Created = DateTime.Now, Type = TrackerType.In},
                new Tracker { Id = 1, Area = areas[1], Created = DateTime.Now, Type = TrackerType.In},
                new Tracker { Id = 2, Area = areas[2], Created = DateTime.Now, Type = TrackerType.In},
                new Tracker { Id = 3, Area = areas[3], Created = DateTime.Now, Type = TrackerType.In},
                new Tracker { Id = 4, Area = areas[4], Created = DateTime.Now, Type = TrackerType.In},
                new Tracker { Id = 5, Area = areas[5], Created = DateTime.Now, Type = TrackerType.In},
                new Tracker { Id = 6, Area = areas[6], Created = DateTime.Now, Type = TrackerType.In},
                new Tracker { Id = 7, Area = areas[7], Created = DateTime.Now, Type = TrackerType.In},
                new Tracker { Id = 8, Area = areas[8], Created = DateTime.Now, Type = TrackerType.In},
                new Tracker { Id = 9, Area = areas[0], Created = DateTime.Now, Type = TrackerType.Out},
                new Tracker { Id = 10, Area = areas[1], Created = DateTime.Now, Type = TrackerType.Out},
                new Tracker { Id = 11, Area = areas[2], Created = DateTime.Now, Type = TrackerType.Out},
                new Tracker { Id = 12, Area = areas[3], Created = DateTime.Now, Type = TrackerType.Out},
                new Tracker { Id = 13, Area = areas[4], Created = DateTime.Now, Type = TrackerType.Out},
                new Tracker { Id = 14, Area = areas[5], Created = DateTime.Now, Type = TrackerType.Out},
                new Tracker { Id = 15, Area = areas[6], Created = DateTime.Now, Type = TrackerType.Out},
                new Tracker { Id = 16, Area = areas[7], Created = DateTime.Now, Type = TrackerType.Out},
                new Tracker { Id = 17, Area = areas[8], Created = DateTime.Now, Type = TrackerType.Out}
            };
            
            context.Trackers.AddRange(trackers);

            //Creation Block in DB : Containers
            var containers = new List<Container>
            {
                new Container { Id = 0, Description = "Colis - Sang", Type = ContainerType.Normal, Created = DateTime.Now, Identifier = "1" },
                new Container { Id = 1, Description = "Colis - Courrier", Type = ContainerType.Normal, Created = DateTime.Now, Identifier = "2" },
                new Container { Id = 2, Description = "Colis - Boite Opératoire", Type = ContainerType.Normal, Created = DateTime.Now, Identifier = "3" },
                new Container { Id = 3, Description = "Colis - Sang", Type = ContainerType.Normal, Created = DateTime.Now, Identifier = "4" }
            };

            context.Containers.AddRange(containers); 
                  
            try
            {
                context.Commit();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
