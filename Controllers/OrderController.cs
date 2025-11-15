using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
<<<<<<< HEAD

namespace SportsStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
=======
namespace SportsStore.Controllers
{
public class OrderController : Controller
    {
    private IOrderRepository repository;
private Cart cart;
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446

        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }
<<<<<<< HEAD

        public ViewResult Checkout() => View(new Order());

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                cart.Clear();
                return RedirectToPage("/Completed", new { orderId = order.OrderID });
            }
            else
            {
                return View();
            }
        }
    }
}
=======
        public ViewResult Checkout() => View(new Order());
[HttpPost]
public IActionResult Checkout(Order order)
{
if (cart.Lines.Count() == 0)
{
ModelState.AddModelError("", "Sorry, your cart is empty!");
}
if (ModelState.IsValid)
{
order.Lines = cart.Lines.ToArray();
repository.SaveOrder(order);
cart.Clear();
return RedirectToPage("/Completed", new { orderId = order.OrderID });
}
else
{
return View();
}
}
}
}
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
