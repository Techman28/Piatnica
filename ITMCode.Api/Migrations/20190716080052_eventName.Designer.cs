﻿// <auto-generated />
using System;
using ITMCode.Piatnica.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITMCode.Piatnica.Api.Migrations
{
    [DbContext(typeof(PiatnicaContext))]
    [Migration("20190716080052_eventName")]
    partial class eventName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.Delay", b =>
                {
                    b.Property<int>("DelayOrder")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Date");

                    b.Property<int>("Id");

                    b.Property<string>("OrderEntryOrderType");

                    b.HasKey("DelayOrder");

                    b.HasIndex("OrderEntryOrderType");

                    b.ToTable("DelaysContext");
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.EventHistory", b =>
                {
                    b.Property<TimeSpan>("Date");

                    b.Property<float>("Distance");

                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.Property<string>("OrderEntryOrderType");

                    b.HasKey("Date");

                    b.HasIndex("OrderEntryOrderType");

                    b.ToTable("EventsHistoriesContext");
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.LocationHistory", b =>
                {
                    b.Property<double>("Longitude");

                    b.Property<TimeSpan>("Date");

                    b.Property<int>("Id");

                    b.Property<double>("LatitudeL");

                    b.HasKey("Longitude");

                    b.HasIndex("Id");

                    b.ToTable("LocationsHistoriesContext");
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Number");

                    b.HasKey("Id");

                    b.ToTable("OrdersContext");
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.OrderEntry", b =>
                {
                    b.Property<string>("OrderType")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cargo");

                    b.Property<string>("Comments");

                    b.Property<TimeSpan>("Date");

                    b.Property<TimeSpan>("FromTime");

                    b.Property<int>("Id");

                    b.Property<string>("Location");

                    b.Property<int>("Status");

                    b.Property<TimeSpan>("ToTime");

                    b.HasKey("OrderType");

                    b.HasIndex("Id");

                    b.ToTable("OrdersEntriesContext");
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.OrderState", b =>
                {
                    b.Property<string>("State")
                        .ValueGeneratedOnAdd();

                    b.Property<TimeSpan>("Date");

                    b.Property<int>("Id");

                    b.HasKey("State");

                    b.HasIndex("Id");

                    b.ToTable("OrdersStatesContext");
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.Delay", b =>
                {
                    b.HasOne("ITMCode.Piatnica.Dal.Models.OrderEntry", "OrderEntry")
                        .WithMany("Delays")
                        .HasForeignKey("OrderEntryOrderType");
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.EventHistory", b =>
                {
                    b.HasOne("ITMCode.Piatnica.Dal.Models.OrderEntry", "OrderEntry")
                        .WithMany("EventHistories")
                        .HasForeignKey("OrderEntryOrderType");
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.LocationHistory", b =>
                {
                    b.HasOne("ITMCode.Piatnica.Dal.Models.Order", "Order")
                        .WithMany("LocationHistories")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.OrderEntry", b =>
                {
                    b.HasOne("ITMCode.Piatnica.Dal.Models.Order", "Order")
                        .WithMany("OrderEntries")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITMCode.Piatnica.Dal.Models.OrderState", b =>
                {
                    b.HasOne("ITMCode.Piatnica.Dal.Models.Order", "Order")
                        .WithMany("OrderState")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
