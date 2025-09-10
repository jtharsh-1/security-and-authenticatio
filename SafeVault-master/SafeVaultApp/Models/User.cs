using Microsoft.AspNetCore.Identity;

namespace SafeVaultApp.Models
{
    public class User : IdentityUser
    {
        public string? Department { get; set; } // optional claim
    }
}
