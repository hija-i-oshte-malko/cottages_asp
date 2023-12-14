using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace cottages_asp.Models.Entities
{
	public class Building
	{
		public Building()
		{
			BuildingId = Guid.NewGuid();
		}
		[Key]
		public Guid BuildingId { get; set; }

		[Required]
		public string Location { get; set; }

		[Required]

		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public int Review { get; set; }

		public ICollection<Offer> Offers { get; set; }

	}
}
