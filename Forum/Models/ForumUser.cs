using Microsoft.AspNetCore.Identity;

namespace Forum.Models
{
    public class ForumUser : IdentityUser
    {
        public string? FirstName {  get; set; } 
    }
}
