using System.ComponentModel.DataAnnotations;

namespace CoolEventsWeb.Models
{
    public class Event
    {
        [Key]
        public int Event_Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        [MaxLength(2097152)]
        public byte[] Photo { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "dd/MM/YYYY")]
        public DateTime PremiereDate { get; set; }
    }
}
