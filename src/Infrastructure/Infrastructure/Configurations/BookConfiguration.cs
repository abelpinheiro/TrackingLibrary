using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasMany(x => x.Authors)
            .WithMany(x => x.Books);

        builder
            .HasOne(x => x.Seller)
            .WithOne(x => x.Book)
            .HasForeignKey<Book>(x => x.SellerId);

        builder
            .HasOne(x => x.Series)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.SeriesId);

        builder
            .HasOne(x => x.Collection)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.CollectionId);

        builder
            .HasMany(x => x.Categories)
            .WithMany(x => x.Books);

        builder
            .Property(x => x.Title)
            .IsRequired();

        builder
            .Property(x => x.CreatedDate)
            .IsRequired();
    }
}