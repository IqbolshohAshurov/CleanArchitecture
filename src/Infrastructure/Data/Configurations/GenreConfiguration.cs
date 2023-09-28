using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder
            .HasMany(s => s.PublishingHouses)
            .WithMany(p => p.Genres)
            .UsingEntity<GenrePublishingHouse>(s => s.ToTable("GenrePublishingHouses"));

        builder
            .HasKey(s => s.Id)
            .HasName("PK_GenreID");

        builder
            .HasIndex(s => s.Title)
            .HasDatabaseName("Key_TitleGenre")
            .IsUnique();

        builder
            .Property(s => s.Id)
            .HasColumnType("uuid")
            .HasColumnOrder(0);

        builder
            .Property(s => s.Title)
            .HasColumnName("name")
            .HasColumnType("text")
            .HasMaxLength(100);

    }
}