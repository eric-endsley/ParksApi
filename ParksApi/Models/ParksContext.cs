using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
    public class ParksApiContext : DbContext
    {
        public ParksApiContext(DbContextOptions<ParksApiContext> options)
            : base(options)
        {
        }
        public DbSet<StatePark> StateParks { get; set;} 

        public DbSet<NatlPark> NatlParks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StatePark>()
                .HasData(
                    new StatePark { StateParkId = 1, Name = "Silver Falls State Park", State = "Oregon" },
                    new StatePark { StateParkId = 2, Name = "Fort Stevens State Park", State = "Oregon" },
                    new StatePark { StateParkId = 3, Name = "Cape Lookout State Park", State = "Oregon" },
                    new StatePark { StateParkId = 4, Name = "Smith Rock State Park", State = "Oregon" }
                );

            builder.Entity<NatlPark>()
                .HasData(   
                    new NatlPark { NatlParkId = 1, Name = "Crater Lake National Park", State= "Oregon"}
                );
        }
    }
}