using Domain.Repository;

namespace Data.EF.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {        
        IPersonRepository PersonRepository { get; }
        IMessageRepository MessageRepository { get; }
        IPersonOrderRepository PersonOrderRepository { get; }
        IOrderRepository OrderRepository { get; }
        ISocialAccountRepository SocialAccountRepository { get; }
        void SaveChanges();
    }
}