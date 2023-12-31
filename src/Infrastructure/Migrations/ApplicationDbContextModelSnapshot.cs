﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("text")
                        .HasColumnName("forename");

                    b.HasKey("Id")
                        .HasName("PK_AuthorID");

                    b.HasIndex("FirstName", "LastName")
                        .HasDatabaseName("Key_Forename");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<int>("CountPage")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<byte>("Edition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((byte)1);

                    b.Property<Guid>("GenreId")
                        .HasMaxLength(50)
                        .HasColumnType("uuid");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<Guid>("PublishingHouseId")
                        .HasMaxLength(50)
                        .HasColumnType("uuid");

                    b.Property<string>("YearOfPublication")
                        .IsRequired()
                        .HasPrecision(4)
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("PK_BookID");

                    b.HasIndex("GenreId");

                    b.HasIndex("Isbn")
                        .IsUnique()
                        .HasDatabaseName("UniqueKey_ISBN");

                    b.HasIndex("Name")
                        .HasDatabaseName("Key_BookName");

                    b.HasIndex("PublishingHouseId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Domain.Entities.BookAuthor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.HasKey("Id")
                        .HasName("PK_BookAuthorID");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.BookLanguage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uuid");

                    b.HasKey("Id")
                        .HasName("PK_BookLanguageID");

                    b.HasIndex("BookId");

                    b.HasIndex("LanguageId");

                    b.ToTable("BookLanguage", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("PK_CityID");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("Key_CityName");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK_GenreID");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasDatabaseName("Key_TitleGenre");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Domain.Entities.GenrePublishingHouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PublishingHouseId")
                        .HasColumnType("uuid");

                    b.HasKey("Id")
                        .HasName("PK_GenrePublishingHouse");

                    b.HasIndex("GenreId");

                    b.HasIndex("PublishingHouseId");

                    b.ToTable("GenrePublishingHouses", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("PK_LanguageID");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("Key_LanguageName");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Domain.Entities.PublishingHouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<Guid>("CityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("PK_PublishingHouseID");

                    b.HasIndex("CityId");

                    b.HasIndex("Name")
                        .HasDatabaseName("Key_PublishingHouseName");

                    b.ToTable("PublishingHouses");
                });

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.HasOne("Domain.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PublishingHouse", "PublishingHouse")
                        .WithMany("Books")
                        .HasForeignKey("PublishingHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("PublishingHouse");
                });

            modelBuilder.Entity("Domain.Entities.BookAuthor", b =>
                {
                    b.HasOne("Domain.Entities.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Domain.Entities.BookLanguage", b =>
                {
                    b.HasOne("Domain.Entities.Book", "Book")
                        .WithMany("BookLanguages")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Language", "Language")
                        .WithMany("BookLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Domain.Entities.GenrePublishingHouse", b =>
                {
                    b.HasOne("Domain.Entities.Genre", "Genre")
                        .WithMany("GenrePublishingHouses")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PublishingHouse", "PublishingHouse")
                        .WithMany("GenrePublishingHouses")
                        .HasForeignKey("PublishingHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("PublishingHouse");
                });

            modelBuilder.Entity("Domain.Entities.PublishingHouse", b =>
                {
                    b.HasOne("Domain.Entities.City", "City")
                        .WithMany("PublishingHouses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Domain.Entities.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookLanguages");
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Navigation("PublishingHouses");
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.Navigation("GenrePublishingHouses");
                });

            modelBuilder.Entity("Domain.Entities.Language", b =>
                {
                    b.Navigation("BookLanguages");
                });

            modelBuilder.Entity("Domain.Entities.PublishingHouse", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("GenrePublishingHouses");
                });
#pragma warning restore 612, 618
        }
    }
}
