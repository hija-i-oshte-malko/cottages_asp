using System.ComponentModel.DataAnnotations;

namespace cottages_asp.Models.Entities;

public class Extra
{
	[Key]
	public Guid Id { get; set; }
	public string Name { get; set; } = default!;
	public string Icon { get; set; } = default!;
	public ICollection<Room> Rooms { get; set; } = default!;
}
