using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace cottages_asp.Models.Entities
{
	public class RoomExtra
	{

		public RoomExtra()
		{
			RoomExtraId = Guid.NewGuid();
		}
		[Key]
		public Guid RoomExtraId { get; set; }

		[ForeignKey("Extra")]
		public Guid ExtraId { get; set; }
		public Extra Extra { get; set; }

		[ForeignKey("Room")]
		public Guid RoomId { get; set; }
		public Room Room { get; set; }
	}
}
