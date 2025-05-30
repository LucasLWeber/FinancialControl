
using FinancialControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialControl.Infrastructure.Data.Configurations
{
    public class OriginConfiguration : IEntityTypeConfiguration<Origin>
    {
        public void Configure(EntityTypeBuilder<Origin> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Name).IsRequired().HasMaxLength(256);
            builder.Property(o => o.Operation).IsRequired();

            builder
                .HasOne(o => o.User)
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
