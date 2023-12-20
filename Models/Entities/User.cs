using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace cottages_asp.Models.Entities
{
	public class User
	{
		public User()
		{
			Id = Guid.NewGuid();
		}
		[Key]
		public Guid Id { get; set; }

		[Required]
		public Boolean IsOffering { get; set; }

		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }

		[Required]
		public string Email { get; set; }
		[Required]
		public string PhonenNumber { get; set; }

		[Required]
		public ICollection<Offer> Offers { get; }
	}
}

