using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
<<<<<<< HEAD

namespace SportsStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
=======
namespace SportsStore.Components
{
public class CartSummaryViewComponent : ViewComponent
{
private Cart cart;
public CartSummaryViewComponent(Cart cartService)
{
cart = cartService;
}
public IViewComponentResult Invoke()
{
return View(cart);
}
}
}
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
