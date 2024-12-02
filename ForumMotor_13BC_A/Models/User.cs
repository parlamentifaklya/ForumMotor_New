using Microsoft.AspNetCore.Identity;

namespace ForumMotor_13BC_A.Models
{
    public class User : IdentityUser
    {
        public string? VezetekNev {  get; set; }
        public string? KeresztNev {  get; set; }
    }
}
