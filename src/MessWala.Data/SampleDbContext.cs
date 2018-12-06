using Microsoft.EntityFrameworkCore;
using System;

namespace MessWala.Data
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
