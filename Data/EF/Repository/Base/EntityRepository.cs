using System.Collections.Generic;
using System.Linq;
using Domain.Entity.Base;
using Domain.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Data.EF.Repository.Base
{
    public abstract class EntityRepository<TEntity> : IEntityRepository<TEntity>
        where TEntity : EntityBase
    {
        protected readonly DbContext dbContext;

        public EntityRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(TEntity entity)
            => this.dbContext.Set<TEntity>().Add(entity);

        public void Delete(TEntity entity)
            => this.dbContext.Set<TEntity>().Remove(entity);

        public ICollection<TEntity> GetAll() => this.dbContext.Set<TEntity>().ToList();

        public TEntity GetById(int id) => this.dbContext.Set<TEntity>().Find(id);

        public void Update(TEntity entity)
            => this.dbContext.Set<TEntity>().Update(entity);
    }
}