using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoolEventsWeb.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Username { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\W).{8,}$", ErrorMessage = "The password must contain at least one uppercase letter and at least one non-alphanumeric character.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [StringLength(255)]
        [DataType(DataType.Text)]
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        [DataType(DataType.Text)]
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [Required]
        public int Role_Id { get; set; }
        [ForeignKey("Role_Id")]
        public Role Role { get; set; }
    }
}
