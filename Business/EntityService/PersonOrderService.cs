using Business.EntityService.Base;
using Business.EntityService.Interface;
using Business.Static;
using Data.EF.UnitOfWork.Interface;
using Domain.Entity;
using Domain.Repository.Base;

namespace Business.EntityService
{
    public class PersonOrderService : EntityServiceBase<PersonOrder>, IPersonOrderService
    {
        public PersonOrderService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IEntityRepository<PersonOrder> GetRepository()
            => this.UnitOfWork.PersonOrderRepository;
    }
}
