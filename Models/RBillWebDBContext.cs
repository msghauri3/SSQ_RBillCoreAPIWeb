using Microsoft.EntityFrameworkCore;

namespace SSQ_RBillCoreAPIWeb.Models
{
    public class RBillWebDBContext : DbContext
    {
        public RBillWebDBContext(DbContextOptions<RBillWebDBContext> options)
            : base(options) { }

        public DbSet<Electricity> Electricity { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Electricity>().HasNoKey();
            modelBuilder.Entity<Maintenance>().HasNoKey();
        }
    }
}
