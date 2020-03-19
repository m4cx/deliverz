using Deliverz.Application.Common.Interfaces;
using Deliverz.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Deliverz.Infrastructure.Storage
{
    public class DeliverzDbContext : DbContext, IDeliverzDbContext
    {
        public DeliverzDbContext(DbContextOptions<DeliverzDbContext> options)
            : base(options)
        { }

        public DbSet<Order> Orders { get; set; }
    }
}
