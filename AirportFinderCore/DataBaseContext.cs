using AirportFinderCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AirportFinderCore
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> opts) : base(opts) { }



        public DbSet<AirportInfo> airportInfo { get; set; }
        public DbSet<CityInfo> cityInfo { get; set; }
        public DbSet<StateImg> stateImg { get; set; }
        public DbSet<FeedBack> feedBack { get; set; }
       

    }
}



