using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
<<<<<<< HEAD

namespace SportsStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
=======
namespace SportsStore.Components
{
  public class NavigationMenuViewComponent : ViewComponent
  {
    private IStoreRepository repository;
    public NavigationMenuViewComponent(IStoreRepository repo)
    {
      repository = repo;
    }
    public IViewComponentResult Invoke()
    {
      ViewBag.SelectedCategory = RouteData?.Values["category"];
      return View(repository.Products
        .Select(x => x.Category)
        .Distinct()
        .OrderBy(x => x));
    }
  }
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
}