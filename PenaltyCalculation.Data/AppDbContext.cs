using Microsoft.EntityFrameworkCore;
using PenaltyCalculation.Data.Entities;

namespace PenaltyCalculation.Data
{
    public class AppDbContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "PenaltyCalculation";

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions connString) : base(connString)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().ToTable("Transactions", DEFAULT_SCHEMA);
            modelBuilder.Entity<Country>().ToTable("Countries", DEFAULT_SCHEMA);

            base.OnModelCreating(modelBuilder);
        }
    }
}
