using System.ComponentModel.DataAnnotations;

namespace CoolEventsWeb.Models
{
    public class Role
    {
        [Key]
        public int Role_Id { get; set; }
        [Required]
        [StringLength(255)]
        [DataType(DataType.Text)]
        public string Role_Name { get; set; }
    }
}
