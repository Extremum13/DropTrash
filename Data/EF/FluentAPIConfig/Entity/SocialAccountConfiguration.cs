using Data.EF.FluentAPIConfig.Entity.Base;
using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.FluentAPIConfig.Entity
{
    public class SocialAccountConfiguration : EntityBaseConfiguration<SocialAccount>
    {
        public override void Configure(EntityTypeBuilder<SocialAccount> builder)
        {
            base.Configure(builder);

            builder.HasOne(sa => sa.Person)
                .WithMany(p => p.SocialAccounts)
                .HasForeignKey(sa => sa.PersonId)
                .IsRequired(true);

            builder.Property(sa => sa.SocialId)
                .IsRequired(true);

            builder.Property(sa => sa.SocialMedia)
                .IsRequired(true);

            builder.Property(sa => sa.SocialMediaId)
                .IsRequired(true);
        }
    }
}