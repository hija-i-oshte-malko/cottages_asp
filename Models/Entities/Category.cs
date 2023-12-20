using System.ComponentModel.DataAnnotations;

namespace cottages_asp.Models.Entities;

public class Category
{
	public Category()
		=> Id = Guid.NewGuid();

	[Key]
	public Guid Id { get; set; }
	public string Name { get; set; } = default!;
	public string Icon { get; set; } = default!;
	public ICollection<Category> Categories { get; set; } = default!;
}
