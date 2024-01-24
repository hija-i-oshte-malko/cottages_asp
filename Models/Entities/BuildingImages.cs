// Example Header

using System.ComponentModel.DataAnnotations.Schema;

namespace cottages_asp.Models.Entities;

public class BuildingImages
{
	public Guid Id { get; set; }
	public string ImageUrl { get; set; }
	[ForeignKey("Building")]
	public Guid BuildingId { get; set; }
	public Building Building { get; set; }
}
