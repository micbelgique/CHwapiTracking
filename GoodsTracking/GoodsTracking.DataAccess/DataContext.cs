using GoodsTracking.DataAccess.Initializers;
using GoodsTracking.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer(new DevelopmentInitializer());
        }

        public virtual void Commit()
        {
            try
            {
                base.SaveChanges();
            }
            catch (Exception ex)
            {
                //logging
                throw;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Tracker> Trackers { get; set; }
    }
}
