using VinylRecords.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;


namespace VinylRecords.Data.Interfaces
{
   public interface IAllPlates
    {
        IEnumerable<Plate> Plates { get; }
        IEnumerable<Plate> getFavPlates { get; }
        Plate getObjectPlate(int plateId);
    }
}
