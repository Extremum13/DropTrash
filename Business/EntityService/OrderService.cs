using Business.EntityService.Base;
using Business.EntityService.Interface;
using Business.Static;
using Data.EF.UnitOfWork.Interface;
using Domain.Entity;
using Domain.Repository.Base;
using System.Collections.;
using System.Collections.Generic;

namespace Business.EntityService
{
    public class OrderService : EntityServiceBase<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IEntityRepository<Order> GetRepository()
            => this.UnitOfWork.OrderRepository;

        public Order AddOrder(IList<int> personsId, param)
        {
            Order order = new Order { };
            this.UnitOfWork.OrderRepository.Add(order);           

            for(int i = 0; i < personsId.Count; i++)
            {
                PersonOrder personOrder = new PersonOrder { PersonId = personsId[i], OrderId = order.Id };
                this.UnitOfWork.PersonOrderRepository.Add(personOrder);
            }

            return order;
        }
    }
}
