using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cottages_asp.Models.Entities;

public class Room
{
	public Room()
		=> Id = Guid.NewGuid();

	[Key]
	public Guid Id { get; set; }
	public string Name { get; set; } = default!;
	public double Price { get; set; }
	public int People { get; set; }

	[ForeignKey("Offer")]
	public Guid OfferId { get; set; }
	public Offer Offer { get; set; } = default!;
	public ICollection<Extra> Extras { get; set; } = default!;
}
