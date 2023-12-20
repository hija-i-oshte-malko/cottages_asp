using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cottages_asp.Models.Entities;

public class Offer
{
	public Offer()
		=> Id = Guid.NewGuid();

	[Key]
	public Guid Id { get; set; }

	[ForeignKey("User")]
	public Guid UserId { get; set; }
	public User User { get; set; } = default!;

	[ForeignKey("Building")]
	public Guid BuildingId { get; set; }
	public Building Building { get; set; } = default!;

	public ICollection<Room> Rooms { get; set; } = default!;
}
