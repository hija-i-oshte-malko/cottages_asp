using System.ComponentModel.DataAnnotations;

namespace cottages_asp.Models.Entities;

public class User
{
	[Key]
	public Guid Id { get; set; }
	public bool IsOffering { get; set; }
	public string Username { get; set; } = default!;
	public string Password { get; set; } = default!;
	public string Email { get; set; } = default!;
	public string Phone { get; set; } = default!;
	public ICollection<Offer> Offers { get; } = default!;
}
