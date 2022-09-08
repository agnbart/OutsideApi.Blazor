using Microsoft.EntityFrameworkCore;
using OutsideApi.Domain;

namespace OutsideApiDb.Data.Interfaces
{
    public interface IBitcoinDbContext
    {
        DbSet<BitcoinMap> Bitcoins { get; set; }
    }
}