using Microsoft.AspNetCore.Mvc;
using VinylRecords.Data.Interfaces;
using VinylRecords.Data.Models;
using VinylRecords.ViewModels;

namespace VinylRecords.Controlers
{
    public class PlatesController : Controller
    {
        private readonly IAllPlates _storekeeper;
        private readonly IPlateCategorizer _plateCategorizer;

        public PlatesController(IAllPlates storekeeper, IPlateCategorizer plateCategorizer)
        {
            _storekeeper = storekeeper;
            _plateCategorizer = plateCategorizer;
        }
        [Route("Plates/List")]
        [Route("Plates/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Plate> plates = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                plates = _storekeeper.Plates.OrderBy(i => i.id);
            }
            else if (string.Equals("Jazz", category, StringComparison.OrdinalIgnoreCase))
            {
                plates = _storekeeper.Plates.Where(i => i.Category.categoryName.Equals("Jazz")).OrderBy(i => i.id);
                currCategory = "Jazz";
            }
            else if (string.Equals("Pop-music", category, StringComparison.OrdinalIgnoreCase))
            {
                plates = _storekeeper.Plates.Where(i => i.Category.categoryName.Equals("Pop-music")).OrderBy(i => i.id);
                currCategory = "Pop-music";
            }
            else if (string.Equals("Rock-music", category, StringComparison.OrdinalIgnoreCase))
            {
                plates = _storekeeper.Plates.Where(i => i.Category.categoryName.Equals("Rock-music")).OrderBy(i => i.id);
                currCategory = "Rock-music";
            }
        
            var plateobj = new PlatesListViewModel
            {
                getAllPlates = plates,
                currCategory = currCategory
            };

            ViewBag.Title = "Pages with plates";

            return View(plateobj);
        }
    }
}
