using Data.EF.FluentAPIConfig.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.FluentAPIConfig.Entity
{
    public class MessageConfiguration : EntityBaseConfiguration<Message>
    {
        public override void Configure(EntityTypeBuilder<Message> builder)
        {
            base.Configure(builder);

            builder.HasOne(m => m.PersonOrder)
                .WithMany(po => po.Messages)
                .HasForeignKey(m => m.PersonOrderId)
                .IsRequired(true);

            builder.Property(o => o.Text)
                .IsRequired(true);
        }
    }
}