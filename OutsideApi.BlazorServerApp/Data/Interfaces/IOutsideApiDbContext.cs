using Microsoft.EntityFrameworkCore;
using OutsideApi.BlazorServerApp.Domain;

namespace OutsideApi.BlazorServerApp.Data.Interfaces
{
    public interface IOutsideApiDbContext
    {
        DbSet<Bitcoin> Bit { get; set; }
    }
}