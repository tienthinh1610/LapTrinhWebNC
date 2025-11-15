using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD

namespace SportsStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Order> Orders => Set<Order>();
    }
}
=======
namespace SportsStore.Models
{
public class StoreDbContext : DbContext
{
public StoreDbContext(DbContextOptions<StoreDbContext> options)
: base(options) { }
public DbSet<Product> Products => Set<Product>();
public DbSet<Order> Orders => Set<Order>();
}
}
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
