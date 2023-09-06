using VinylRecords.Data.Interfaces;
using VinylRecords.Data.Models;

namespace VinylRecords.Mocks
{
    public class MockPlates : IAllPlates
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
                     img = "/img/Depeche_Mode_Enjoy_the_Silence_1990.jpg",
                     isFavourite = true,
                     price = 20,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.First()
                  },
                 new Plate {
                     name = "Jimi Hendrix – Are You Experienced",
                     shortDescription = "Are You Experienced is the debut studio album by the rock band." ,
                     longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1967",
                     img = "/img/jimmie.jpg",
                     isFavourite = true,
                     price = 35,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.First()
                  },
                  new Plate {
                     name = "Louis Armstrong In – Los Angeles",
                     shortDescription = "Louis Armstrong is rightly celebrated as a master jazz trumpeter, but his distinctive gravelly-voiced singing also had a huge influence on later artists." ,
                     longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1970",
                     img = "/img/louis.jpg",
                     isFavourite = true,
                     price = 30,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.Last()
                  },
                  new Plate {
                     name = "Weather Report – 8:30",
                     shortDescription = "8:30 is the second live album from the jazz fusion group Weather Report, issued in 1979." ,
                     longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: US\r\nReleased: 1979",
                     img = "/img/Weather_Report.jpg",
                     isFavourite = true,
                     price = 25,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.Last()
                  },
                  new Plate {
                     name = "The Weeknd - Starboy",
                     shortDescription = "Starboy is the third studio album by Canadian singer the Weeknd." ,
                     longDescription = "Format: Vinyl, 12\", 25 RPM, Maxi-Single\r\nCountry: US\r\nReleased: 2016",
                     img = "/img/starboy.jpg",
                     isFavourite = true,
                     price = 30,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.Last()
                  },
                  new Plate {
                     name = "The Beatles - Abbey Road",
                     shortDescription = "Abbey Road is the eleventh studio album by the English rock band the Beatles." ,
                     longDescription = "Format: Vinyl, 12\", 25 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1970",
                     img = "/img/abbey-road.jpg",
                     isFavourite = true,
                     price = 50,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.Last()
                  },
                  new Plate {
                     name = "Pink Floyd - The dark side of the moon",
                     shortDescription = "The Dark Side of the Moon is the eighth studio album by the English rock band Pink Floyd." ,
                     longDescription = "Format: Vinyl, 10\", 15 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1973",
                     img = "/img/pink-floyd.jpg",
                     isFavourite = true,
                     price = 25,
                     avaliable = true,
                     Category = _categoryPlates.AllCategories.Last()
                  },
                  new Plate {
                     name = "The Rolling Stones - Exile on Main St.",
                     shortDescription = "Exile on Main St. is the 10th British and 12th American studio album by the English rock band the Rolling Stones.." ,
                     longDescription = "Format: Vinyl, 10\", 15 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1972",
                     img = "/img/RolStones.jpg",
                     isFavourite = true,
                     price = 35,
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
