using Deliverz.Application.Common.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Deliverz.Application.Orders.Queries
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, IQueryable<OrderDto>>
    {
        private readonly IDeliverzDbContext context;

        public GetOrdersQueryHandler(IDeliverzDbContext context)
        {
            this.context = context;
        }

        public async Task<IQueryable<OrderDto>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = context.Orders
                .Select(x => new OrderDto
                {
                    Id = x.Id,
                    Created = x.Created,
                    Description = x.Description
                });

            return await Task.FromResult(orders).ConfigureAwait(false);
        }
    }
}
