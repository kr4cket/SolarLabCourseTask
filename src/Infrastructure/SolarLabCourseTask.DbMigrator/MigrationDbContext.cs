using SolarLabCourseTask.DataAccess;

namespace SolarLabCourseTask.DbMigrator;

public class MigrationDbContext : AppDbContext
{
    public MigrationDbContext(Microsoft.EntityFrameworkCore.DbContextOptions options) : base(options)
    {
    }
}