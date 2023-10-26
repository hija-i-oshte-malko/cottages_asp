using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace cottages_asp.Models.Entities
{
    public class Extra
    {
        public Extra()
        {
            ExtraId = Guid.NewGuid();
        }
        [Key]
        public Guid ExtraId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Icon { get; set; }

        public ICollection<RoomExtra> RoomExtras { get; set; }
    }
}
