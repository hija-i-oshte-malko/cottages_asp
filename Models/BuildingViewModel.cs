// Example Header

using cottages_asp.Models.Entities;

namespace cottages_asp.Models;

public class BuildingViewModel
{
	public string Location { get; set; } = default!;
	public string Name { get; set; } = default!;
	public string Description { get; set; } = default!;
	public int Review { get; set; }
	public ICollection<Offer> Offers { get; set; } = default!;
	public ICollection<Category> Categories { get; set; } = default!;
}
