using Microsoft.EntityFrameworkCore;

namespace VinylRecords.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent addDBContent)
        {
            this.appDBContent = addDBContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCarItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        { 
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }
        public void AddToCart(Plate plate)
        {
            this.appDBContent.ShopCarItem.Add(new ShopCarItem
            {
                ShopCartId = ShopCartId,
                plate = plate,
                price = plate.price
            });
            appDBContent.SaveChanges();
        }
        public List<ShopCarItem> getShopItems()
        { 
            return appDBContent.ShopCarItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.plate).ToList(); 
        }
           
    }
}
