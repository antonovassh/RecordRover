using WebAplShop.Data.Interfaces;
using WebAplShop.Data.Models;

namespace WebAplShop.Mocks
{
    public class MockPlates : IStorekeeper
    {
        private readonly IPlateCategorizer _categoryPlates = new MockCategory();
        public IEnumerable<Plate> Plates
        {
            get
            {
                return new List<Plate>{
                 new Plate {
                     name = "Depeche Mode – Enjoy The Silence",
                     shortDescription = "\"Enjoy the Silence\" is a song by English electronic music band Depeche Mode." ,
                     longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1990",
                     img = "https://upload.wikimedia.org/wikipedia/ru/9/9a/Depeche_Mode_Enjoy_the_Silence_1990.jpg",
                     isFavourite = true,
                     price = 20,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.First()
                  },
                 new Plate {
                     name = "Jimi Hendrix – Are You Experienced",
                     shortDescription = "Are You Experienced is the debut studio album by the rock band." ,
                     longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1967",
                     img = "https://thesoundofvinyl.us/cdn/shop/products/2545585_500x500.jpg?v=1583485031",
                     isFavourite = true,
                     price = 35,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.First()
                  },
                  new Plate {
                     name = "Louis Armstrong In – Los Angeles",
                     shortDescription = "Louis Armstrong is rightly celebrated as a master jazz trumpeter, but his distinctive gravelly-voiced singing also had a huge influence on later artists." ,
                     longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1970",
                     img = "https://i.discogs.com/c0gI_521iQrDCqdu1lwNHo9Vgc0396qc0HLAF_pQUSg/rs:fit/g:sm/q:90/h:500/w:500/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTQ1ODQw/NDMtMTM2OTA4NzY3/Ni03OTkzLmpwZWc.jpeg",
                     isFavourite = true,
                     price = 30,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.Last()
                  },
                  new Plate {
                     name = "Weather Report – 8:30",
                     shortDescription = "8:30 is the second live album from the jazz fusion group Weather Report, issued in 1979." ,
                     longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: US\r\nReleased: 1979",
                     img = "https://upload.wikimedia.org/wikipedia/en/8/88/Weather_Report_830.jpg",
                     isFavourite = true,
                     price = 25,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.Last()
                  },

            };
            }
        }
        public IEnumerable<Plate> getFavPlates { set; get; }

        public Plate getObjectPlate(int plateId)
        {
            throw new NotImplementedException();
        }
    }
}
