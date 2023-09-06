using VinylRecords.Data.Interfaces;
using VinylRecords.Data.Models;

namespace VinylRecords.Mocks
{
    public class MockCategory : IPlateCategorizer
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
            new Category {
                categoryName = "Rock-music",
                description = "Rock music is a form of popular music that emerged in the 1950s and is defined as “a form of music with a strong beat”"
            },
            new Category {
                categoryName = "Jazz",
                description = "Jazz music is a broad style of music characterized by complex harmony, syncopated rhythms, and a heavy emphasis on improvisation."
            },
            //new Category {categoryName = "Pop-music", description = "Pop music is a very broad term that describes music " +
            //"that is popular in the mainstream. "}
             };
            }
        }
    }
}










