using Data.EF.FluentAPIConfig.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.FluentAPIConfig.Entity
{
    public class PersonOrderConfiguration : EntityBaseConfiguration<PersonOrder>
    {
        public override void Configure(EntityTypeBuilder<PersonOrder> builder)
        {
            base.Configure(builder);

            builder.HasOne(po => po.Person)
                .WithMany(p => p.PersonOrders)
                .HasForeignKey(po => po.PersonId)
                .IsRequired(true);

            builder.HasOne(po => po.Order)
                .WithMany(p => p.PersonOrders)
                .HasForeignKey(po => po.OrderId)
                .IsRequired(true);

            builder.HasMany(po => po.Messages)
                .WithOne(m => m.PersonOrder)
                .HasForeignKey(m => m.PersonOrderId)
                .IsRequired(true);

            builder.Property(po => po.Role)
                .IsRequired(true);

            builder.Property(po => po.Weight)
                .IsRequired(true);

            builder.Property(po => po.Cost)
                .IsRequired(true);

            builder.Property(po => po.Address)
                .IsRequired(true);
        }
    }
}