using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ITMCode.Piatnica.Dal.Models;

namespace ITMCode.Piatnica.Dal
{
    public class PiatnicaContext : DbContext
    {
        public DbSet<Delay> DelaysContext { get; set; }
        public DbSet<EventHistory> EventsHistoriesContext { get; set; }
        public DbSet<LocationHistory> LocationsHistoriesContext { get; set; }
        public DbSet<Order> OrdersContext { get; set; }
        public DbSet<OrderEntry> OrdersEntriesContext { get; set; }
        public DbSet<OrderState> OrdersStatesContext { get; set; }

        private string DatabasePath { get; set; }

        public PiatnicaContext()
        {

        }   public PiatnicaContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }

        public PiatnicaContext(string databasePath)
        {
            DatabasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer("server=KOMP11\\SQLEXPRESS;Database=Piatnica;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EventHistory>()
                .HasOne<OrderEntry>(s => s.OrderEntry)
                .WithMany(s => s.EventHistories);

            //modelBuilder.Entity<DistanceHistory>()
              //  .HasOne<Event>(s => s.Event)
                //.WithMany(s => s.DistanceHistories);

            modelBuilder.Entity<Delay>()
                .HasOne<OrderEntry>(s => s.OrderEntry)
                .WithMany(s => s.Delays);

            modelBuilder.Entity<OrderState>()
              .HasOne<Order>(s => s.Order)
              .WithMany(s => s.OrderState);

            modelBuilder.Entity<LocationHistory>()
              .HasOne<Order>(s => s.OrderId)
              .WithMany(s => s.LocationHistories);

            modelBuilder.Entity<OrderEntry>()
              .HasOne<Order>(s => s.Order)
              .WithMany(s => s.OrderEntries);





        }
    }
}