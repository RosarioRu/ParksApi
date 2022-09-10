using Microsoft.EntityFrameworkCore;
using System;

namespace ParksApi.Models 
{
  public class ParksApiContext : DbContext 
  {
    public ParksApiContext(DbContextOptions<ParksApiContext> options)
      :base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(

          new Park {ParkId = 11, ParkName = "Denali", CityOrClosestCity = "Denali Park", State = "Alaska", DateEstablished = new DateTime(1917, 2, 26 ), AreaInAcres = 4740911.16, StateOrNational = "National Park"},

          new Park {ParkId = 12, ParkName = "Crater Lake", CityOrClosestCity = "Klamath Falls", State = "Oregon", DateEstablished = new DateTime(1902, 5, 22), AreaInAcres = 183224.05, StateOrNational = "National Park"},

          new Park {ParkId = 13, ParkName = "Grand Teton", CityOrClosestCity = "Moose", State = "Wyoming", DateEstablished = new DateTime(1929, 2, 26), AreaInAcres = 310044.36, StateOrNational = "National Park"},

          new Park {ParkId = 14, ParkName = "Olympic", CityOrClosestCity = "Port Angeles", State = "Washington", DateEstablished = new DateTime(1938, 6, 29), AreaInAcres = 922649.41, StateOrNational = "National Park"},

          new Park {ParkId = 15, ParkName = "Glacier", CityOrClosestCity = "Kalispell", State = "Montana", DateEstablished = new DateTime(1910, 5, 11), AreaInAcres = 1013126.39, StateOrNational = "National Park"},

          new Park {ParkId = 16, ParkName = "Dry Tortugas", CityOrClosestCity = "Key West", State = "Florida", DateEstablished = new DateTime(1992, 10, 26), AreaInAcres = 64701.22, StateOrNational = "National Park"},

          new Park {ParkId = 17, ParkName = "Catherine Creek State Park", CityOrClosestCity = "Union", State = "Oregon", DateEstablished = new DateTime(1932, 1, 1), AreaInAcres = 168, StateOrNational = "State Park"},

          new Park {ParkId = 18, ParkName = "Wallowa Lake State Park", CityOrClosestCity = "Joseph", State = "Oregon", DateEstablished = new DateTime(1941, 1, 1), AreaInAcres = 165, StateOrNational = "State Park"},

          new Park {ParkId = 19, ParkName = "Range Pond", CityOrClosestCity = "Poland", State = "Maine", DateEstablished = new DateTime(1965, 1, 1), AreaInAcres = 740, StateOrNational = "State Park"},

          new Park {ParkId = 20, ParkName = "Big Bend", CityOrClosestCity = "Terlingua", State = "Texas", DateEstablished = new DateTime(1944, 6, 12), AreaInAcres = 801163.21, StateOrNational = "National Park"}
        );
    }

    public DbSet<Park> Parks { get; set; }

  }
}