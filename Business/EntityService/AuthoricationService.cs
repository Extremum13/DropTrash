using Business.EntityService.Base;
using Business.EntityService.Interface;
using Business.Static;
using Data.EF.UnitOfWork.Interface;
using Domain.Entity;
using Domain.Enum;
using Domain.Repository.Base;
using System;

namespace Business.EntityService
{
    public class AuthorizationService : EntityServiceBase<Person>, IAuthorizationService
    {
        public AuthorizationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IEntityRepository<Person> GetRepository()
            => this.UnitOfWork.PersonRepository;

        public Person CreatePersonBySocial(string socialId, SocialMedia socialMedia, string firstName, string secondName, DateTime birthDate, bool canBeDriver = false)
        {
            Person person = new Person { FirstName = firstName, SecondName = secondName, Birthday = birthDate, CanBeDriver = canBeDriver };
            this.GetRepository().Add(person);
            SocialAccount socialAccount = new SocialAccount { SocialId = socialId, SocialMedia = socialMedia, PersonId = person.Id };
            this.UnitOfWork.SocialAccountRepository.Add(socialAccount);

            return person;
        }
    }
}