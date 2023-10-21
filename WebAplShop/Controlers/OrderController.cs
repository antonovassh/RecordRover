using Microsoft.AspNetCore.Mvc;
using VinylRecords.Data;
using VinylRecords.Data.Interfaces;
using VinylRecords.Data.Models;

namespace VinylRecords.Controlers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }
        public IActionResult Chekout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Chekout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if(shopCart.listShopItems.Count == 0 ) 
            {
                ModelState.AddModelError("", "Your cart is empty");
            }
            if (ModelState.IsValid) 
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete () 
        {
            ViewBag.Message = "Your order is registered";
            return View();
        }
    }
}
