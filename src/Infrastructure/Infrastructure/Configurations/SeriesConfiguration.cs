using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class SeriesConfiguration : IEntityTypeConfiguration<Series>
{
    public void Configure(EntityTypeBuilder<Series> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasMany(x => x.Authors)
            .WithMany(x => x.Series);

        builder
            .HasMany(x => x.Categories)
            .WithMany(x => x.Series);

        builder
            .Property(x => x.QuantityOwn)
            .IsRequired();
        
        builder
            .Property(x => x.QuantityTotal)
            .IsRequired();

        builder
            .Property(x => x.CreatedDate)
            .IsRequired();
        
        builder
            .Property(x => x.ModificationDate)
            .IsRequired();
    }
}