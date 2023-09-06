using VinylRecords.Data.Models;

namespace VinylRecords.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Plates.Any())
                content.AddRange(
                    new Plate
                    {
                        name = "Depeche Mode – Enjoy The Silence",
                        shortDescription = "\"Enjoy the Silence\" is a song by English electronic music band Depeche Mode.",
                        longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1990",
                        img = "/img/Depeche_Mode_Enjoy_the_Silence_1990.jpg",
                        isFavourite = true,
                        price = 20,
                        avaliable = true,
                        Category = Categories["Pop-music"]
                    },
                     new Plate
                     {
                         name = "Jimi Hendrix – Are You Experienced",
                         shortDescription = "Are You Experienced is the debut studio album by the rock band.",
                         longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1967",
                         img = "/img/jimmie.jpg",
                         isFavourite = true,
                         price = 35,
                         avaliable = true,
                         Category = Categories["Rock-music"]
                     },
                      new Plate
                      {
                          name = "Louis Armstrong In – Los Angeles",
                          shortDescription = "Louis Armstrong is rightly celebrated as a master jazz trumpeter, but his distinctive gravelly-voiced singing also had a huge influence on later artists.",
                          longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1970",
                          img = "/img/louis.jpg",
                          isFavourite = true,
                          price = 30,
                          avaliable = true,
                          Category = Categories["Jazz"]
                      },
                      new Plate
                      {
                          name = "Weather Report – 8:30",
                          shortDescription = "8:30 is the second live album from the jazz fusion group Weather Report, issued in 1979.",
                          longDescription = "Format: Vinyl, 12\", 45 RPM, Maxi-Single\r\nCountry: US\r\nReleased: 1979",
                          img = "/img/Weather_Report.jpg",
                          isFavourite = true,
                          price = 25,
                          avaliable = true,
                          Category = Categories["Rock-music"]
                      },
                      new Plate
                      {
                          name = "The Weeknd - Starboy",
                          shortDescription = "Starboy is the third studio album by Canadian singer the Weeknd.",
                          longDescription = "Format: Vinyl, 12\", 25 RPM, Maxi-Single\r\nCountry: US\r\nReleased: 2016",
                          img = "/img/starboy.jpg",
                          isFavourite = true,
                          price = 30,
                          avaliable = true,
                          Category = Categories["Pop-music"]
                      },
                      new Plate
                      {
                          name = "The Beatles - Abbey Road",
                          shortDescription = "Abbey Road is the eleventh studio album by the English rock band the Beatles.",
                          longDescription = "Format: Vinyl, 12\", 25 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1970",
                          img = "/img/abbey-road.jpg",
                          isFavourite = true,
                          price = 50,
                          avaliable = true,
                          Category = Categories["Rock-music"]
                      },
                      new Plate
                      {
                          name = "Pink Floyd - The dark side of the moon",
                          shortDescription = "The Dark Side of the Moon is the eighth studio album by the English rock band Pink Floyd.",
                          longDescription = "Format: Vinyl, 10\", 15 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1973",
                          img = "/img/pink-floyd.jpg",
                          isFavourite = true,
                          price = 25,
                          avaliable = true,
                          Category = Categories["Rock-music"]
                      },
                      new Plate
                      {
                          name = "The Rolling Stones - Exile on Main St.",
                          shortDescription = "Exile on Main St. is the 10th British and 12th American studio album by the English rock band the Rolling Stones..",
                          longDescription = "Format: Vinyl, 10\", 15 RPM, Maxi-Single\r\nCountry: UK\r\nReleased: 1972",
                          img = "/img/RolStones.jpg",
                          isFavourite = true,
                          price = 35,
                          avaliable = true,
                          Category = Categories["Rock-music"]
                      }
                    );
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                         new Category { categoryName = "Rock-music",  description = "Rock music is a form of popular music that emerged in the 1950s and is defined as “a form of music with a strong beat”" },
                         new Category { categoryName = "Jazz", description = "Jazz music is a broad style of music characterized by complex harmony, syncopated rhythms, and a heavy emphasis on improvisation." },
                         new Category { categoryName = "Pop-music", description = "Pop music is a genre of popular music that originated in its modern form during the mid-1950s." }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}

