using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Book> Books { get; }
    public DbSet<Author> Authors { get; }
    public DbSet<Language> Languages { get; }
    public DbSet<City> Cities { get; }
    public DbSet<PublishingHouse> PublishingHouses { get; }
    public DbSet<Genre> Genres { get; }

    public DbSet<BookAuthor> BookAuthors { get; }
    public DbSet<BookLanguage> BookLanguage { get; }
    public DbSet<GenrePublishingHouse> GenrePublishingHouses { get; }

    Task<int> SaveChangeAsync(CancellationToken cancellationToken);
}