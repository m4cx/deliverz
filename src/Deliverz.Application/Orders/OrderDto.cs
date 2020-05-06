using Deliverz.Application.Common.Mappings;
using Deliverz.Domain.Orders;
using System;

namespace Deliverz.Application.Orders
{
    public class OrderDto : IMapFrom<Order>
    {
        public Guid? Id { get; set; }

        public DateTime Created { get; set; }

        public string Description { get; set; }
    }
}
