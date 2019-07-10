using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Piatnica.Dal.Models;

namespace Piatnica.Dal
{
    public class PiatnicaContext : DbContext
    {
        public DbSet <Delay> DelaysContext { get; set; }
        public DbSet<DistanceHistory> DistancesHistoryContext { get; set; }
        public DbSet<Event> EventsContext { get; set; }
        public DbSet<EventHistory> EventsHistoriesContext { get; set; }
        public DbSet<LocationHistory> LocationsHistoriesContext { get; set; }
        public DbSet <Order> OrdersContext { get; set; }
        public DbSet<OrderEntry> OrdersEntriesContext { get; set; }
        public DbSet<OrderState> OrdersStatesContext { get; set; }

        private string DatabasePath { get; set; }

        public PiatnicaContext()
        {

        }

        public PiatnicaContext(string databasePath)
        {
            DatabasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventHistory>()
                .HasOne<Event>(s => s.Event)
                .WithMany(g => g.EventHistories);

            modelBuilder.Entity<EventHistory>()
                .HasOne<OrderEntry>(s => s.OrderEntry)
                .WithMany(s => s.eventHistories);

            modelBuilder.Entity<DistanceHistory>()
                .HasOne<Event>(s => s.Event)
                .WithMany(s => s.DistanceHistories);

            modelBuilder.Entity<Delay>()
                .HasOne<OrderEntry>(s => s.OrderEntry)
                .WithMany(s => s.delays);

            modelBuilder.Entity<OrderState>()
              .HasOne<Order>(s => s.order)
              .WithMany(s => s.orderState);

            modelBuilder.Entity<LocationHistory>()
              .HasOne<Order>(s => s.order)
              .WithMany(s => s.locationHistories);

            modelBuilder.Entity<DistanceHistory>()
              .HasOne<Order>(s => s.order)
              .WithMany(s => s.distanceHistories);

            modelBuilder.Entity<OrderEntry>()
              .HasOne<Order>(s => s.order)
              .WithMany(s => s.orderEntries);





        }
    }
}