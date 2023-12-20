using System.ComponentModel.DataAnnotations;
namespace cottages_asp.Models.Entities;
public class Building
{
	public Building()
		=> Id = Guid.NewGuid();

	[Key]
	public Guid Id { get; set; }
	public string Location { get; set; } = default!;
	public string Name { get; set; } = default!;
	public string Description { get; set; } = default!;
	public int Review { get; set; }
	public ICollection<Offer> Offers { get; set; } = default!;
	public ICollection<Category> Categories { get; set; } = default!;
}
