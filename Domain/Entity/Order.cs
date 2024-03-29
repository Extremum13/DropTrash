﻿using Domain.Entity.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class Order : EntityBase
    {
        public virtual ICollection<PersonOrder> PersonOrders { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public int TotalCost { get; set; }
        public string Description { get; set; }
    }
}
