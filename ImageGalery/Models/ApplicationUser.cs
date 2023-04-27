using Microsoft.AspNetCore.Identity;

namespace ImageGalery.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? FullName { get; set; }

        public List<Image>? Images { get; set; }//One to Many --->table relatiship
    }
}
