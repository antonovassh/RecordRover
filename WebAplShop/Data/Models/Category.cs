namespace VinylRecords.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string description { set; get; }

        public List<Category> categories { set; get; }
    }
}
