using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class UserConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(x => x.UserId)
            .HasName("PK_UserId");
        
        builder
            .Property(x => x.UserId)
            .HasColumnType("uuid");
        
        builder
            .Property(x => x.UserName)
            .HasColumnType("text");

        builder
            .HasIndex(x => x.UserName);

    }
}