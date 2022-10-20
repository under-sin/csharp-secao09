using System;
using Program03.Entities.Enums;

namespace Program03.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                   + ", "
                   + Moment
                   + ", "
                   + Status;
        }
    }
}

