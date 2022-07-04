using Microsoft.AspNetCore.Identity;

namespace CareStationProject.Models
{
    public class AppUser : IdentityUser 
    {
        public string ?  City  { get; set; }
    }
}
