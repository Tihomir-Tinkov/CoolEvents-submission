using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoolEventsWeb.Models
{
    public class Ticket
    {
        [Key]
        public int Ticket_Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User User { get; set; }
        [Required]
        public int Event_Id { get; set; }
        [ForeignKey("Event_Id")]
        public Event Event { get; set; }
    }
}
