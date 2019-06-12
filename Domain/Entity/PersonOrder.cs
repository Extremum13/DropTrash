using Domain.Entity.Base;
using Domain.Enum;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class PersonOrder : EntityBase
    {
        public int? PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int? OrderId { get; set; }
        public virtual Order Order { get; set; }
        public PersonRole Role { get; set; }
        public int Weight { get; set; }
        public int Cost { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
