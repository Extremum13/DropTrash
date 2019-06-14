using System.Collections.Generic;
using Business.EntityService.Base.Interface;
using Business.Static;
using Data.EF.UnitOfWork.Interface;
using Domain.Entity.Base;
using Domain.Repository.Base;

namespace Business.EntityService.Base
{
    public abstract class EntityServiceBase<TEntity> : IEntityService<TEntity>
        where TEntity : EntityBase
    {
        private readonly IUnitOfWork unitOfWork;

        public EntityServiceBase(IUnitOfWork unitOfWork)
        {
            CheckArgument.CheckForNull(unitOfWork, nameof(unitOfWork));
            this.unitOfWork = unitOfWork;
        }

        public ICollection<TEntity> GetAll() => this.GetRepository().GetAll();

        public TEntity GetById(int id) => this.GetRepository().GetById(id);

        protected abstract IEntityRepository<TEntity> GetRepository();

        protected IUnitOfWork UnitOfWork => this.unitOfWork;
    }
}