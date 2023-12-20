using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace cottages_asp.Models.Entities
{
	public class Category
	{
		public Category()
		{
			CategoryId = Guid.NewGuid();
		}
		[Key]
		public Guid CategoryId { get; set; }

		[Required]
		public string Name { get; set; }
		[Required]
		public string Icon { get; set; }

		ICollection<CategoryHotel> CategoryHotels { get; set; }


	}
}
