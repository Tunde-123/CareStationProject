using System.ComponentModel.DataAnnotations;

namespace CareStationProject.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public  string Email { get; set; }

        [Required]
        
        [Display(Name = "User Name")]
        public string UserName{ get; set; }

        [Required]
        [Display(Name ="Password")]
        [DataType(DataType.Password)] 
        [StringLength(100, ErrorMessage ="the {0} must be at least {2} character long", MinimumLength = 6)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password do not match")]
        public string  ConfirmPassword { get; set; }

        public string? ReturnUrl { get; set; }
        public string  City { get; set; }
    }
}
