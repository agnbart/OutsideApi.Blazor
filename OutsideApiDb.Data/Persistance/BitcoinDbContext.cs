using Microsoft.EntityFrameworkCore;
using OutsideApi.Domain;
using OutsideApiDb.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApiDb.Data.Persistance
{
    public class BitcoinDbContext : DbContext, IBitcoinDbContext
    {
        public BitcoinDbContext()
        {

        }
        public BitcoinDbContext(DbContextOptions<BitcoinDbContext> options) : base(options)
        {

        }

        public DbSet<BitcoinMap> Bitcoins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BitcoinMap>(b => b.Property(x => x.symbol));
            modelBuilder.Entity<BitcoinMap>(b => b.Property(x => x.name));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = LAPTOP-T0UMOPBI; Initial Catalog = OutsideApi; Trusted_Connection = True;");
        }
    }
}
