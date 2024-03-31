using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SolarLabCourseTask.DataAccess.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<Domain.Users.Entity.User>
{
    public void Configure(EntityTypeBuilder<Domain.Users.Entity.User> builder)
    {
        builder
            .ToTable("Users")
            .HasKey(u => u.Id);

        builder
            .Property(u => u.FirstName)
            .IsRequired()
            .HasMaxLength(255);
        
        builder
            .Property(u => u.LastName)
            .IsRequired()
            .HasMaxLength(255);

        builder
            .Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(255);
        
        builder
            .Property(u => u.Phone)
            .HasMaxLength(255);
        
        builder
            .Property(u => u.Password)
            .IsRequired()
            .HasMaxLength(255);
        
        builder
            .Property(u => u.Role)
            .IsRequired()
            .HasDefaultValue(0);
    }
}