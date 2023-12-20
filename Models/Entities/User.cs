using Microsoft.AspNetCore.Identity;

namespace cottages_asp.Models.Entities;

public class User : IdentityUser<Guid>
{
	public string FirstName { get; set; } = default!;
	public string LastName { get; set; } = default!;
}
