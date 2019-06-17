using Data.EF.Repository;
using Data.EF.UnitOfWork.Interface;
using Domain.Repository;

namespace Data.EF.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DropTrashContext dbContext;

        private IPersonRepository personRepository;
        private IOrderRepository orderRepository;
        private IPersonOrderRepository personOrderRepository;
        private ISocialAccountRepository socialAccountRepository;
        private IMessageRepository messageRepository;

        public IOrderRepository OrderRepository => this.orderRepository
            ?? (this.orderRepository = new OrderRepository(this.dbContext));

        public IPersonRepository PersonRepository => this.personRepository
            ?? (this.personRepository = new PersonRepository(this.dbContext));

        public IPersonOrderRepository PersonOrderRepository => this.personOrderRepository
            ?? (this.personOrderRepository = new PersonOrderRepository(this.dbContext));

        public ISocialAccountRepository SocialAccountRepository => this.socialAccountRepository
            ?? (this.socialAccountRepository = new SocialAccountRepository(this.dbContext));

        public IMessageRepository MessageRepository => this.messageRepository
            ?? (this.messageRepository = new MessageRepository(this.dbContext));

        public UnitOfWork(DropTrashContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void SaveChanges() => this.dbContext.SaveChanges();
    }
}