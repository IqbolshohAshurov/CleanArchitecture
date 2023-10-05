using System.Dynamic;
using System.Reflection;
using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data;

public class ApplicationDbContext: DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    /*public ApplicationDbContext()
    {
        this.Configuration.LazyLoadingEnabled = false;
    }*/
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Language> Languages => Set<Language>();
    public DbSet<City> Cities => Set<City>();
    public DbSet<PublishingHouse> PublishingHouses => Set<PublishingHouse>();
    public DbSet<Genre> Genres => Set<Genre>();

    public DbSet<BookAuthor> BookAuthors => Set<BookAuthor>();
    public DbSet<BookLanguage> BookLanguage => Set<BookLanguage>();
    public DbSet<GenrePublishingHouse> GenrePublishingHouses => Set<GenrePublishingHouse>();
    public Task<int> SaveChangeAsync(CancellationToken cancellationToken)
    {
        return base.SaveChangesAsync();
        //throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
    
    
}