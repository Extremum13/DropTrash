using Business.EntityService.Base;
using Business.EntityService.Interface;
using Business.Static;
using Data.EF.UnitOfWork.Interface;
using Domain.Entity;
using Domain.Repository.Base;

namespace Business.EntityService
{
    public class PersonService : EntityServiceBase<Person>, IPersonService
    {
        public PersonService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IEntityRepository<Person> GetRepository()
            => this.UnitOfWork.PersonRepository;
    }
}
