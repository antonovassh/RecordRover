using Microsoft.AspNetCore.Server.IIS.Core;
using VinylRecords.Data.Interfaces;
using VinylRecords.Data.Models;

namespace VinylRecords.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopCart.listShopItems;

            foreach(var el in items) 
            {
                var orderDetail = new OrderDetail()
                {
                    plateID = el.plate.id,
                    OrderID = order.Id,
                    price = el.plate.price,
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
