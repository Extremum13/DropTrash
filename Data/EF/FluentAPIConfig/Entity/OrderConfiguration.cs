using Data.EF.FluentAPIConfig.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.FluentAPIConfig.Entity
{
    public class OrderConfiguration : EntityBaseConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.HasMany(o => o.PersonOrders)
                .WithOne(po => po.Order)
                .HasForeignKey(po => po.OrderId)
                .IsRequired(true);

            builder.Property(o => o.Date)
                .IsRequired(true);

            builder.Property(o => o.Description)
                .IsRequired(false);

            builder.Property(o => o.Capacity)
                .IsRequired(true);

            builder.Property(o => o.TotalCost)
                .IsRequired(true);
        }
    }
}