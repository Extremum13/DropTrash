using Data.EF.FluentAPIConfig.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.FluentAPIConfig.Entity
{
    public class PersonConfiguration : EntityBaseConfiguration<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);

            builder.HasMany(p => p.PersonOrders)
                .WithOne(po => po.Person)
                .HasForeignKey(po => po.PersonId)
                .IsRequired(true);

            builder.HasMany(p => p.SocialAccounts)
                .WithOne(sa => sa.Person)
                .HasForeignKey(sa => sa.PersonId)
                .IsRequired(true);

            builder.Property(p => p.FirstName)
                .IsRequired(true);

            builder.Property(p => p.SecondName)
                .IsRequired(true);

            builder.Property(p => p.Birthday)
                .IsRequired(true);

            builder.Property(p => p.CanBeDriver)
                .IsRequired(true);
        }
    }
}