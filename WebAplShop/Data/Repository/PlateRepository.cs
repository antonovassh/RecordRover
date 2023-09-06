using VinylRecords.Data.Interfaces;
using VinylRecords.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using VinylRecords.Data;


namespace VinylRecords.Data.Reposytory

{
    public class PlateRepository : IAllPlates
    {
        private readonly AppDBContent appDBContent;
        public PlateRepository(AppDBContent addDBContent)
        {
            this.appDBContent = addDBContent;
        }

        public IEnumerable<Plate> Plates => appDBContent.Plates.Include(c => c.Category);

        public IEnumerable<Plate> getFavPlates => appDBContent.Plates.Where(p => p.isFavourite).Include(c => c.Category);

        public Plate getObjectPlate(int plateId) => appDBContent.Plates.FirstOrDefault(p => p.id == plateId);
    }
}
