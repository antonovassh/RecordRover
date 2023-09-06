using VinylRecords.Data.Models;

namespace VinylRecords.Data.Interfaces


{
   public interface IPlateCategorizer
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

