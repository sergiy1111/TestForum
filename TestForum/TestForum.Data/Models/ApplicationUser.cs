using Microsoft.AspNetCore.Identity;

namespace TestForum.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Rating = 0;
            ProfileImageUrl = " ";
            MemberSince = DateTime.Now;
            IsActive = true;
        }

        public int Rating { get; set; }
        public string ProfileImageUrl { get; set; }
        public DateTime MemberSince { get; set; }
        public bool IsActive { get; set; }
    }
}
