using Business.EntityService.Base.Interface;
using Domain.Entity;

namespace Business.EntityService.Interface
{
    public interface IMessageService : IEntityService<Message>
    {
        void CreateMessage(int personId, int OrderId, string message);
    }
}