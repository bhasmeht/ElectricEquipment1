using System.ComponentModel.DataAnnotations;

namespace ElectronicEquipment.Models
{
    public class UpdatePassword
    {
        [Required(ErrorMessage ="Please Enter UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Please Enter Your Current Password")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Please Enter New Password")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage ="Please Enter Confirm Password")]
        public string ConfirmPassword { get; set;}
    }
}
