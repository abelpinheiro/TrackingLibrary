using Microsoft.EntityFrameworkCore;
using TL.Catalog.Domain.Models;

namespace TL.Catalog.Infrastructure.Context;

public class CatalogContext : DbContext
{
    public CatalogContext(DbContextOptions options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    /*public DbSet<Series> Series { get; set; }
    public DbSet<Collection> Collections { get; set; }*/
    public DbSet<Author> Authors { get; set; }
    /*public DbSet<Seller> Sellers { get; set; }
    public DbSet<Category> Categories { get; set; }*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        /*modelBuilder.Entity<Book>()
            .HasOne(a => a.Seller)
            .WithOne(s => s.Book)
            .HasForeignKey<Seller>(b => b.Id);

        modelBuilder.Entity<Book>()
            .HasOne(b => b.Series)
            .WithMany(s => s.Books);*/
    }
}