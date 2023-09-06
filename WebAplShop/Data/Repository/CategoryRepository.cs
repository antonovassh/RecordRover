using VinylRecords.Data.Interfaces;
using VinylRecords.Data.Models;

namespace VinylRecords.Data.Reposytory
{
    public class CategoryRepository : IPlateCategorizer
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent addDBContent)
        {
            this.appDBContent = addDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
