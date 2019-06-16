using Data.EF.Repository.Base;
using Domain.Entity;
using Domain.Enum;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.EF.Repository
{
    public class PersonRepository : EntityRepository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Person GetPersonBySocialMedia(string socialId, SocialMedia socialMedia)
            => this.dbContext.Set<Person>().FirstOrDefault(p => p.SocialAccounts.Any(sa => sa.SocialId.Equals(socialId) && sa.SocialMedia.Equals(socialMedia)));
    }
}
