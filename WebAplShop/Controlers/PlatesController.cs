using Microsoft.AspNetCore.Mvc;
using VinylRecords.Data.Interfaces;
using VinylRecords.ViewModels;

namespace VinylRecords.Controlers
{
    public class PlatesController : Controller
    {
        private readonly IAllPlates _storekeeper;
        private readonly IPlateCategorizer _plateCategorizer;

        public PlatesController (IAllPlates storekeeper, IPlateCategorizer plateCategorizer)
        {
            _storekeeper = storekeeper;
            _plateCategorizer = plateCategorizer;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Pages with plates";
           PlatesListViewModel obj = new PlatesListViewModel();
            obj.getAllPlates = _storekeeper.Plates;
            obj.currCategory = "Plates";

            return View(obj);
        }
    }
}
