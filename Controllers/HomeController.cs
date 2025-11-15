using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;
        
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string? category,int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                 .Where(p => category == null || p.Category == category) // Lọc theo danh mục
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null 
                        ? repository.Products.Count() 
                        : repository.Products.Where(e => e.Category == category).Count() // Đếm theo danh mục
                },
                CurrentCategory = category // Truyền danh mục hiện tại
            });
    }
=======

using SportsStore.Models;

using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers

{

  public class HomeController : Controller

  {

    private IStoreRepository repository;

    public int PageSize = 4;

    public HomeController(IStoreRepository repo)

    {

      repository = repo;

    }

    public ViewResult Index(string? category, int productPage = 1)

    => View(new ProductsListViewModel

    {

      Products = repository.Products

    .Where(p => category == null || p.Category == category)

    .OrderBy(p => p.ProductID)

    .Skip((productPage - 1) * PageSize)

    .Take(PageSize),

      PagingInfo = new PagingInfo

      {

        CurrentPage = productPage,

        ItemsPerPage = PageSize,

        TotalItems = category == null
          ? repository.Products.Count()
          : repository.Products.Where(e =>
              e.Category == category).Count()

      },

      CurrentCategory = category

    });

  }

>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
}