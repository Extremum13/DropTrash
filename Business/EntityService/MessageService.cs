using Business.EntityService.Base;
using Business.EntityService.Interface;
using Business.Static;
using Data.EF.UnitOfWork.Interface;
using Domain.Entity;
using Domain.Repository.Base;

namespace Business.EntityService
{
    public class MessageService : EntityServiceBase<Message>, IMessageService
    {
        public MessageService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void CreateMessage(int personId, int OrderId, string message)
        {
            throw new System.NotImplementedException();
        }

        protected override IEntityRepository<Message> GetRepository()
            => this.UnitOfWork.MessageRepository;
    }
}
