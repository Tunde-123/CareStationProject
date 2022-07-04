using System.ComponentModel.DataAnnotations;

namespace CareStationProject.ViewModel
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
