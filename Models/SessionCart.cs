using System.Text.Json.Serialization;
using SportsStore.Infrastructure;
<<<<<<< HEAD

namespace SportsStore.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()
                .HttpContext?.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession? Session { get; set; }

        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session?.SetJson("Cart", this);
        }

        public override void RemoveLine(Product product)
        {
            base.RemoveLine(product);
            Session?.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session?.Remove("Cart");
        }
    }
}
=======
namespace SportsStore.Models
{
public class SessionCart : Cart
{
public static Cart GetCart(IServiceProvider services)
{
ISession? session = services.GetRequiredService<IHttpContextAccessor>()
.HttpContext?.Session;
SessionCart cart = session?.GetJson<SessionCart>("Cart")
?? new SessionCart();
cart.Session = session;
return cart;
}
[JsonIgnore]
public ISession? Session { get; set; }
public override void AddItem(Product product, int quantity)
{
base.AddItem(product, quantity);
Session?.SetJson("Cart", this);
}
public override void RemoveLine(Product product)
{
base.RemoveLine(product);
Session?.SetJson("Cart", this);
}
public override void Clear()
{
base.Clear();
Session?.Remove("Cart");
}
}
}
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
