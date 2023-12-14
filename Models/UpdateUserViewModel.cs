using cottages_asp.Models.Entities;

namespace cottages_asp.Models;

public class UpdateUserViewModel
{
	public Guid Id { get; set; }


	public Boolean IsOffering { get; set; }


	public string Username { get; set; }

	public string Password { get; set; }


	public string Email { get; set; }

	public string PhonenNumber { get; set; }

}
