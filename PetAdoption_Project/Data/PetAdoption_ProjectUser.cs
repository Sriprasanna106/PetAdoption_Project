using Microsoft.AspNetCore.Identity;

namespace PetAdoption_Project.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class PetAdoption_ProjectUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
