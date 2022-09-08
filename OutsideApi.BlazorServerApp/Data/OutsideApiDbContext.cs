using Microsoft.EntityFrameworkCore;
using OutsideApi.BlazorServerApp.Data.Interfaces;
using OutsideApi.BlazorServerApp.Domain;
using OutsideApi.Domain;

namespace OutsideApi.BlazorServerApp.Data
{
    public class OutsideApiDbContext : DbContext, IOutsideApiDbContext
    {
        public OutsideApiDbContext(DbContextOptions<OutsideApiDbContext> options) : base(options)
        {

        }

        public DbSet<Bitcoin> Bit { get; set; }
    }
}
