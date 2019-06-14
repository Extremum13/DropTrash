using System.Collections.Generic;
using Domain.Entity.Base;

namespace Business.EntityService.Base.Interface
{
    public interface IEntityService<TEntity>
        where TEntity : EntityBase
    {
        ICollection<TEntity> GetAll();
        TEntity GetById(int id);
    }
}