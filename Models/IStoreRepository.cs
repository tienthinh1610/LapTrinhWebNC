<<<<<<< HEAD
namespace SportsStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);
=======
namespace SportsStore.Models {
    public interface IStoreRepository {
        IQueryable<Product> Products { get; }
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
    }
}