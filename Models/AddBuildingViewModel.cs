using System.ComponentModel.DataAnnotations;

namespace cottages_asp.Models
{
	public class AddBuildingViewModel
	{
		public Guid BuildingId { get; set; }

		public string Location { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int Review { get; set; }
	}

}
