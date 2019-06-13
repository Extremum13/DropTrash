using Data.EF.FluentAPIConfig.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.EF.FluentAPIConfig
{
    public sealed class ModelConfigurationHandler
    {
        public void SetConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SocialAccountConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PersonOrderConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
        }
    }
}