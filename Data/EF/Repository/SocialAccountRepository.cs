using Data.EF.Repository.Base;
using Domain.Entity;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EF.Repository
{
    public class SocialAccountRepository : EntityRepository<SocialAccount>, ISocialAccountRepository
    {
        public SocialAccountRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public CheckIfAccountExists()
    }
}
