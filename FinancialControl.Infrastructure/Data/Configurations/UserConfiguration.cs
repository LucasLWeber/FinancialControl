

using FinancialControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialControl.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(256);
            builder.Property(u => u.Surname).IsRequired().HasMaxLength(256);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(256);
            builder.Property(u => u.Document).HasMaxLength(11);
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.CreatedAt).IsRequired();
            builder.Property(u => u.UpdatedAt).IsRequired(false);
            builder.Property(u => u.DeletedAt).IsRequired(false);
            builder.HasIndex(u => u.Email).IsUnique();
        }
    }
}
