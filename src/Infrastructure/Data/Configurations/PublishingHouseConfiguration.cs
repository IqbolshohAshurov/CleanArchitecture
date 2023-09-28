using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class PublishingHouseConfiguration: IEntityTypeConfiguration<PublishingHouse>
{
    public void Configure(EntityTypeBuilder<PublishingHouse> builder)
    {
        builder
            .HasKey(p => p.Id)
            .HasName("PK_PublishingHouseID");

        builder
            .HasIndex(p => p.Name)
            .HasDatabaseName("Key_PublishingHouseName");

        builder
            .Property(p => p.Id)
            .HasColumnType("uuid")
            .HasColumnOrder(0);

        builder
            .Property(p => p.Name)
            .HasColumnType("text")
            .HasMaxLength(100);

        builder
            .Property(p => p.CityId)
            .HasColumnType("uuid");

    }
}