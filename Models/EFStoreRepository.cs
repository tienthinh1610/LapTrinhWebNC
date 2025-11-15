<<<<<<< HEAD
namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;

        public void CreateProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteProduct(Product p)
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public void SaveProduct(Product p)
        {
            context.SaveChanges();
        }
=======
namespace SportsStore.Models {
    public class EFStoreRepository : IStoreRepository {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx) {
            context = ctx;
}
        public IQueryable<Product> Products => context.Products;
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
    }
}