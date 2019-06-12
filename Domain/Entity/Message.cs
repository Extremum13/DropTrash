using Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Message : EntityBase
    {
        public string Text { get; set; }
        public int PersonOrderId { get; set; }
        public virtual PersonOrder PersonOrder { get; set; }
    }
}
