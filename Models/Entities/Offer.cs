using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cottages_asp.Models.Entities
{
    public class Offer
    {
        public Offer()
        {
            OfferId = Guid.NewGuid();
        }
        [Key]
        public Guid OfferId { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; } 
        public User User { get; set; }

        [ForeignKey("Building")]
        public Guid BuildingId { get; set; } 
        public Building Building { get; set; }

        ICollection<Room> Rooms { get; set; }
    }
}