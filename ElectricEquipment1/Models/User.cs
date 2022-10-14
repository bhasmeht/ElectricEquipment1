using System.ComponentModel.DataAnnotations;

namespace ElectronicEquipment.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Please Enter UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Please Enter Password")]
        [MinLength(8,ErrorMessage ="Length of Password must be atleast 8 character long")]
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
