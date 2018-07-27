using Microsoft.EntityFrameworkCore;
using vega.Models;


namespace vega.Persistance
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            :base(options)
        {

        }

        public virtual DbSet<Make> Makes { get; set; }

        public virtual DbSet<Model> Models { get; set; }
    }
}
