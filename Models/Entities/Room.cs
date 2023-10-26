using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cottages_asp.Models.Entities
{
    public class Room
    {
        public Room()
        {
            RoomId = Guid.NewGuid();
        }
        [Key]
        public Guid RoomId { get; set; }

        [Required]
        public string Name { get; set; }
       
        [Required]
        public double Price { get; set; }
       
        [Required]
        public int People { get; set; }


        [ForeignKey("Offer")]
        public Guid OfferId { get; set; }
        public Offer Offer { get; set; }

        public ICollection<RoomExtra> RoomExtras { get; set; }


    }
}
