using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD

namespace SportsStore.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private StoreDbContext context;

        public EFOrderRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
=======
namespace SportsStore.Models
{
public class EFOrderRepository : IOrderRepository
{
private StoreDbContext context;
public EFOrderRepository(StoreDbContext ctx)
{
context = ctx;
}
public IQueryable<Order> Orders => context.Orders
.Include(o => o.Lines)
.ThenInclude(l => l.Product);
public void SaveOrder(Order order)
{
context.AttachRange(order.Lines.Select(l => l.Product));
if (order.OrderID == 0)
{
context.Orders.Add(order);
}
context.SaveChanges();
}
}
}
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
