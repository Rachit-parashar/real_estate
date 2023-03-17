using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RealEstate.Models.Dto
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Please enter a User Name")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
