using Microsoft.AspNetCore.Identity;

namespace aspnet_identity_app.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
