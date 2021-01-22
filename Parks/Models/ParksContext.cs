using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
        }
        public DbSet<StatePark> StateParks { get; set;} 

        public DbSet<NatlPark> NatlParks { get; set; }
    }

  
}