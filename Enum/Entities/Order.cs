using System;
using Enum.Entities.Enums;
using System.Text;

namespace Enum.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id +
                ", " +
                Moment +
                ", " +
                Status;
        }
    }
}
