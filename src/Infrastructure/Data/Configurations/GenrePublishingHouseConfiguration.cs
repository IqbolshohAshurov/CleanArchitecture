using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class GenrePublishingHouseConfiguration : IEntityTypeConfiguration<GenrePublishingHouse>
{
    public void Configure(EntityTypeBuilder<GenrePublishingHouse> builder)
    {
        builder
            .HasOne(sp => sp.Genre)
            .WithMany(s => s.GenrePublishingHouses)
            .HasForeignKey(sp => sp.GenreId);

        builder
            .HasOne(sp => sp.PublishingHouse)
            .WithMany(p => p.GenrePublishingHouses)
            .HasForeignKey(sp => sp.PublishingHouseId);

        builder
            .HasKey(sp => sp.Id)
            .HasName("PK_GenrePublishingHouse");

        builder
            .Property(sp => sp.Id)
            .HasColumnType("uuid")
            .HasColumnOrder(0);
    }
}