using Microsoft.EntityFrameworkCore;
using SolarLabCourseTask.DataAccess.Configurations;


namespace SolarLabCourseTask.DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<Domain.Users.Entity.User> Users {get; set;}
    public DbSet<Domain.Ads.Entity.Ads> Ads {get; set;}
    public DbSet<Domain.Ads.Entity.Photos> Photos {get; set;}
    public DbSet<Domain.Category.Entity.Categories> Categories {get; set;}
    public DbSet<Domain.Category.Entity.Category> Category {get; set;}

    public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}
