using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RealEstate.Models.Dto
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Please select one of the catagory")]

        public string UserRole { get; set; }
        [Required(ErrorMessage = "Please enter a User Name")]
        [Display(Name = "Username")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [NotMapped]
        [Display(Name = "Conform Password")]

        [Compare("Password")]
        public string ConformPassword { get; set; }

        [Required]

        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
        public string Email { get; set; }
        [Required]

        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get; set; }
    }
}
