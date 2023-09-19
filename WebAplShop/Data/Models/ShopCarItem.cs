namespace VinylRecords.Data.Models
{
    public class ShopCarItem
    {
        public int id { get; set; }
        public Plate plate { get; set; }
        public decimal price { get; set; }
        public string ShopCartId { get; set; }
    }
}
