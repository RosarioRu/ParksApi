﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    partial class ParksApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AreaInAcres")
                        .HasColumnType("double");

                    b.Property<string>("CityOrClosestCity")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateEstablished")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ParkName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12) CHARACTER SET utf8mb4");

                    b.Property<string>("StateOrNational")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            AreaInAcres = 4740911.1600000001,
                            CityOrClosestCity = "Denali Park",
                            DateEstablished = new DateTime(1917, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParkName = "Denali",
                            State = "Alaska",
                            StateOrNational = "National Park"
                        },
                        new
                        {
                            ParkId = 2,
                            AreaInAcres = 183224.04999999999,
                            CityOrClosestCity = "Klamath Falls",
                            DateEstablished = new DateTime(1902, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParkName = "Crater Lake",
                            State = "Oregon",
                            StateOrNational = "National Park"
                        },
                        new
                        {
                            ParkId = 3,
                            AreaInAcres = 310044.35999999999,
                            CityOrClosestCity = "Moose",
                            DateEstablished = new DateTime(1929, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParkName = "Grand Teton",
                            State = "Wyoming",
                            StateOrNational = "National Park"
                        },
                        new
                        {
                            ParkId = 4,
                            AreaInAcres = 922649.41000000003,
                            CityOrClosestCity = "Port Angeles",
                            DateEstablished = new DateTime(1938, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParkName = "Olympic",
                            State = "Washington",
                            StateOrNational = "National Park"
                        },
                        new
                        {
                            ParkId = 5,
                            AreaInAcres = 1013126.39,
                            CityOrClosestCity = "Kalispell",
                            DateEstablished = new DateTime(1910, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParkName = "Glacier",
                            State = "Montana",
                            StateOrNational = "National Park"
                        },
                        new
                        {
                            ParkId = 6,
                            AreaInAcres = 64701.220000000001,
                            CityOrClosestCity = "Key West",
                            DateEstablished = new DateTime(1992, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParkName = "Dry Tortugas",
                            State = "Florida",
                            StateOrNational = "National Park"
                        },
                        new
                        {
                            ParkId = 7,
                            AreaInAcres = 168.0,
                            CityOrClosestCity = "Union",
                            DateEstablished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1932),
                            ParkName = "Catherine Creek State Park",
                            State = "Oregon",
                            StateOrNational = "State Park"
                        },
                        new
                        {
                            ParkId = 8,
                            AreaInAcres = 165.0,
                            CityOrClosestCity = "Joseph",
                            DateEstablished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1941),
                            ParkName = "Wallowa Lake State Park",
                            State = "Oregon",
                            StateOrNational = "State Park"
                        },
                        new
                        {
                            ParkId = 9,
                            AreaInAcres = 740.0,
                            CityOrClosestCity = "Poland",
                            DateEstablished = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1965),
                            ParkName = "Range Pond",
                            State = "Maine",
                            StateOrNational = "State Park"
                        },
                        new
                        {
                            ParkId = 10,
                            AreaInAcres = 801163.20999999996,
                            CityOrClosestCity = "Terlingua",
                            DateEstablished = new DateTime(1944, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParkName = "Big Bend",
                            State = "Texas",
                            StateOrNational = "National Park"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
