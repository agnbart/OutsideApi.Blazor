using Microsoft.EntityFrameworkCore;
using OutsideApi.Domain;

namespace OutsideApi.BlazorServerApp.Data
{
    public interface IOutsideApiDbContext
    {
        DbSet<TestMap> Tests { get; set; }
        DbSet<BooksOfAuthorMap> Booki { get; set; }
    }
}