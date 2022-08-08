using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class TrackingLibraryDbContext : DbContext
{
    public TrackingLibraryDbContext(DbContextOptions<TrackingLibraryDbContext> options)
    : base(options)
    {
        
    }

    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Book> Books => Set<Book>();
}