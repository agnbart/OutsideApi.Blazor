using Microsoft.EntityFrameworkCore;
using OutsideApi.Domain;

namespace OutsideApi.BlazorServerApp.Data
{
    public class OutsideApiDbContext : DbContext, IOutsideApiDbContext
    {
        public OutsideApiDbContext(DbContextOptions<OutsideApiDbContext> options) : base(options)
        {

        }
        public DbSet<TestMap> Tests { get; set; }
        public DbSet<BooksOfAuthorMap> Booki { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BooksOfAuthorMap>(b => b.HasNoKey());
        }
    }
}
