using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class BookConfiguration: IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder
            .HasMany(b => b.Authors)
            .WithMany(a => a.Books)
            .UsingEntity<BookAuthor>(j => j.ToTable("BookAuthors"));

        builder
            .HasMany(b => b.Languages)
            .WithMany(l => l.Books)
            .UsingEntity<BookLanguage>(j => j.ToTable("BookLanguage"));


        builder
            .HasKey(b => b.Id)
            .HasName("PK_BookID");

        builder
            .HasIndex(b => b.Name)
            .HasName("Key_BookName");

        builder
            .Property(b => b.Id)
            .HasColumnType("uuid")
            .HasColumnOrder(0);

        builder
            .Property(b => b.Name)
            .HasColumnType("text")
            .HasMaxLength(100);

        builder
            .Property(b => b.CountPage)
            .HasColumnType("int")
            .HasMaxLength(5);

        builder
            .Property(b => b.YearOfPublication)
            .HasColumnType("text")
            .HasPrecision(4);

        builder
            .Property(b => b.Description)
            .HasColumnType("text");

        builder
            .Property(b => b.Photo)
            .HasColumnType("text");

        builder
            .Property(b => b.Isbn)
            .HasColumnType("text")
            .HasMaxLength(13);
        builder
            .HasIndex(b => b.Isbn)
            .HasDatabaseName("UniqueKey_ISBN")
            .IsUnique();

        builder
            .Property(b => b.Edition)
            .HasDefaultValue("1")
            .HasColumnType("smallint");

        builder
            .Property(b => b.GenreId)
            .HasColumnType("uuid").HasMaxLength(50);

        builder
            .Property(b => b.PublishingHouseId)
            .HasColumnType("uuid")
            .HasMaxLength(50);
/*
        builder
            .Property(b => b.CreatedAt)
            .HasColumnType("date")
            .HasPrecision(8);

        builder
            .Property(b => b.UpdatedAt)
            .HasColumnType("date")
            .HasPrecision(8);
*/
    }
}