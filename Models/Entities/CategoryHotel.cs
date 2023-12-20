using cottages_asp.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cottages_asp.Models.Entities
{
	public class CategoryHotel
	{
		public CategoryHotel()
		{
			CategoryHotelId = Guid.NewGuid();
		}
		[Key]
		public Guid CategoryHotelId { get; set; }

		[ForeignKey("Building")]
		public Guid BuildingId { get; set; }
		public Building Building { get; set; }

		[ForeignKey("Category")]
		public Guid CategoryId { get; set; }
		public Category Category { get; set; }

	}
}
