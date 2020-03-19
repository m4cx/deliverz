using Deliverz.Core;
using MediatR;
using System.Linq;

namespace Deliverz.Application.Orders.Queries
{
    public class GetOrdersQuery : IRequest<IQueryable<OrderDto>>
    {
    }
}
