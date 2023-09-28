using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder
            .HasKey(c => c.Id)
            .HasName("PK_CityID");

        builder
            .HasIndex(c => c.Name)
            .HasDatabaseName("Key_CityName")
            .IsUnique();

        builder
            .Property(c => c.Id)
            .HasColumnType("uuid")
            .HasColumnOrder(0);

        builder
            .Property(c => c.Name)
            .HasColumnType("text")
            .HasMaxLength(70);

    }
}