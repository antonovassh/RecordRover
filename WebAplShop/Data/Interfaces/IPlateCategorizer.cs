using WebAplShop.Data.Models;

namespace WebAplShop.Data.Interfaces


{
   public interface IPlateCategorizer
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

