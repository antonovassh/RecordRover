namespace VinylRecords.Data.Models
{
    public class Plate
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDescription { set; get; }

        public string longDescription { set; get; }

        public string img { set; get; }

        public decimal price { set; get; }

        public bool isFavourite { set; get; }

        public bool avaliable { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
