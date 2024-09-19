using GameLibraryApi.Modules.Items;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameLibraryApi.Context;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemDetail> ItemDetails { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        SeedUsers(modelBuilder);
        SeedItems(modelBuilder);
    }

    private void SeedUsers(ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<IdentityUser>();

        // Seed users
        var user = new IdentityUser
        {
            Id = "1", // Primary key
            UserName = "oskar.eriksson@skoglit.se",
            NormalizedUserName = "OSKAR.ERIKSSON@SKOGLIT.SE",
            Email = "oskar.eriksson@skoglit.sm",
            NormalizedEmail = "OSKAR.ERIKSSON@SKOGLIT.SE",
        };

        user.PasswordHash = hasher.HashPassword(user, "1234");

        modelBuilder.Entity<IdentityUser>().HasData(user);
    }

    private void SeedItems(ModelBuilder modelBuilder)
    {
        for (var i = 1; i <= 10; i++)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = i,
                    Name = "Item " + i,
                    Description = "Item " + i + " description",
                    Status = Status.Backlog,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
        }
    }
}