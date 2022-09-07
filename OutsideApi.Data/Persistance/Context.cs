using Microsoft.EntityFrameworkCore;
using OutsideApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApi.Data.Persistance
{
    public class Context : DbContext
    {
        private string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ExternalAPI;Trusted_Connection=True;";
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Currency> MyProperty { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
