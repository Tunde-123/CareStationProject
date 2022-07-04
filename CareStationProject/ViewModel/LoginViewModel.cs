using System.ComponentModel.DataAnnotations;

namespace CareStationProject.ViewModel
{
    public class LoginViewModel
    {   [Required]
       
        [Display(Name = "Email")]
        public string Email  { get; set; }
       
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } 
        
        public string ? ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}
