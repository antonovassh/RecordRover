using Microsoft.AspNetCore.Mvc;
using WebAplShop.Data.Interfaces;

namespace WebAplShop.Controlers
{
    public class PlatesController : Controller
    {
        private readonly IStorekeeper _storekeeper;
        private readonly IPlateCategorizer _plateCategorizer;

        public PlatesController (IStorekeeper storekeeper, IPlateCategorizer plateCategorizer)
        {
            _storekeeper = storekeeper;
            _plateCategorizer = plateCategorizer;
        }
        public ViewResult List()
        {
            var plates = _storekeeper.Plates;
            return View(plates);
        }
    }
}
