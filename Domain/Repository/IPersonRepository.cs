using Domain.Entity;
using Domain.Enum;
using Domain.Repository.Base;

namespace Domain.Repository
{
    public interface IPersonRepository : IEntityRepository<Person>
    {
        Person GetPersonBySocialMedia(string socialId, SocialMedia socialMedia);

    }
}