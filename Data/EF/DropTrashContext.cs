using System.Collections.Generic;
using System.Linq;
using Data.EF.FluentAPIConfig;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.EF
{
    public class DropTrashContext : DbContext
    {
        public DropTrashContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ModelConfigurationHandler().SetConfigurations(modelBuilder);
        }

        private void Initialize()
        {
            

            this.SaveChanges();
        }

        public DbSet<Order> Families { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonOrder> PersonFamilies { get; set; }
        public DbSet<SocialAccount> PersonWallets { get; set; }
        public DbSet<Message> Transactions { get; set; }
    }
}