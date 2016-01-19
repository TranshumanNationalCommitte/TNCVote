using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace TNCVote.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string BirthDate { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string CitizenshipCountry { get; set; }
        [EmailAddress]
        public override string Email { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Sex { get; set; }
        public string IncomeRange { get; set; }
        public string Education { get; set; }
        public string Married { get; set; }
        public override string PhoneNumber { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Blog { get; set; }
        public string Website { get; set; }
        public string Title { get; set; }
        public string Profession { get; set; }

        public string IPAddress { get;  set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }
    }
}