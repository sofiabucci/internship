using Microsoft.AspNetCore.Identity;

namespace Authentication.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    }
}
