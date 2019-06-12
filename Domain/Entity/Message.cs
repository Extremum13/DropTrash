using Domain.Entity.Base;

namespace Domain.Entity
{
    public class Message : EntityBase
    {
        public string Text { get; set; }
        public int PersonOrderId { get; set; }
        public virtual PersonOrder PersonOrder { get; set; }
    }
}
