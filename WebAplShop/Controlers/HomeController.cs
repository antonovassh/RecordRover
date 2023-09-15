using Microsoft.AspNetCore.Mvc;
using VinylRecords.ViewModels;
using Microsoft.AspNetCore.Mvc;
using VinylRecords.Data.Interfaces;
using VinylRecords.ViewModels;

namespace VinylRecords.Controlers
{
    public class HomeController : Controller
    {
        private readonly IAllPlates _storekeeper;
        private readonly IPlateCategorizer _plateCategorizer;
        public HomeController(IAllPlates storekeeper, IPlateCategorizer plateCategorizer)
        {
            _storekeeper = storekeeper;
            _plateCategorizer = plateCategorizer;
        }
        public IActionResult Index()
        {
            PlatesListViewModel obj = new PlatesListViewModel();
            obj.getAllPlates = _storekeeper.Plates;
            obj.currCategory = "Plates";

            return View(obj);
        }
    }
}
