namespace VinylRecords.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderID{ get; set; }

        public int plateID { get; set; }
        public decimal price { get; set; }
        public virtual Plate plate { get; set; }

        public virtual Order order { get; set; }

    }
}
