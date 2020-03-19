using Deliverz.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Deliverz.Application.Common.Interfaces
{
    public interface IDeliverzDbContext
    {
        DbSet<Order> Orders { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
