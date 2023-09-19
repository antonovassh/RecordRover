using Microsoft.AspNetCore.Mvc;
using VinylRecords.Data.Interfaces;
using VinylRecords.Data.Models;
using VinylRecords.Data.Reposytory;
using VinylRecords.ViewModels;

namespace VinylRecords.Controlers
{
    public class ShopCartController : Controller
    {
        private readonly IAllPlates _plateRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllPlates plateRep, ShopCart shopCart)
        {
            _plateRep = plateRep;
            _shopCart = shopCart;
        }
        public ViewResult Index()
        { 
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }
        public RedirectToActionResult addToCart(int id)
        {
            var item = _plateRep.Plates.FirstOrDefault(i => i.id == id);
            if (item != null) 
            {
                _shopCart.AddToCart(item);
            }
           return  RedirectToAction("Index");
        }
    }
}
