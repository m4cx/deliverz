using Deliverz.Core;
using System;

namespace Deliverz.Domain.Orders
{
    public class Order : Entity<Guid>
    {
        public DateTime Created { get; set; }

        public string Description { get; set; }
    }
}
