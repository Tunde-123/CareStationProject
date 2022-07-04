using System.ComponentModel.DataAnnotations;

namespace CareStationProject.ViewModel
{
    public class ExternalLoginViewModel
    {   [Required]
        public string Email { get; set; }  
        [Required]
        public string Name { get; set; }
        public string  City { get; set; }
    }
}
