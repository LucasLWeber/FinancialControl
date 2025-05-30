

using FinancialControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialControl.Infrastructure.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.CreatedAt).IsRequired();
            builder.Property(t => t.Amount).IsRequired();

            builder
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.Origin)
                .WithMany()
                .HasForeignKey("OriginId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
