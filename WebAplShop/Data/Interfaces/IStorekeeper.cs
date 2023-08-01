using WebAplShop.Data.Models;

namespace WebAplShop.Data.Interfaces
{
   public interface IStorekeeper
    {
        IEnumerable<Plate> Plates { get; }
        IEnumerable<Plate> getFavPlates { set; get; }
        Plate getObjectPlate(int plateId);
    }
}
