using VinylRecords.Data.Models;

namespace VinylRecords.ViewModels
{
	public class PlatesListViewModel
	{
		public IEnumerable<Plate> getAllPlates {  get; set; }
		public string currCategory { get; set; }
	}
}
