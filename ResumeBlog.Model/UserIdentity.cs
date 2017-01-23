using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ResumeBlog.Model.BlogModelClasses;
using ResumeBlog.Model.ResumeModelClasses;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ResumeBlog.Model
{
    public class UserIdentity : IdentityUser
    {


        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public bool IsRecruiter { get; set; }

        public bool IsDeveloper { get; set; }

        public string PhotoUrl { get; set; }

        public string PhoneMobile { get; set; }

        public string AboutMe { get; set; }

        public string Ip { get; set; }

        public int? CompanyId { get; set; }

        public Company Company { get; set; }


        public DeveloperProfile DeveloperProfile { get; set; }

        public int? DeveloperProfileId { get; set; }

        public IEnumerable<Post> Posts { get; set; } = new List<Post>();

        public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<UserIdentity> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
