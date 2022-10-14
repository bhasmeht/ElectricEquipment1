using System.ComponentModel.DataAnnotations;

namespace ElectronicEquipment.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Please Enter UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Please Enter Password")]
        public string Password { get; set; }
    }
}
