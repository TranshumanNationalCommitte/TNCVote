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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public string BirthDate { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Country Of Citizenship")]
        public string CitizenshipCountry { get; set; }
        
        [EmailAddress]
        [Display(Name ="Email Address")]
        public override string Email { get; set; }
      
        [Display(Name = "City of Residence")]
        public string City { get; set; }

        [Display(Name = "County of Residence")]
        public string County { get; set; }

        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Display(Name = "Income Range")]
        public string IncomeRange { get; set; }

        [Display(Name = "Education")]
        public string Education { get; set; }

        [Display(Name = "Married")]
        public string Married { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        [Display(Name = "Phone Number")]
        public override string PhoneNumber { get; set; }

        [RegularExpression(@"^[(http(s)?):\\/\\/(www\\.)?a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]‌​{2,6}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)$", ErrorMessage = "You must enter a valid url.")]
        [Display(Name = "Twitter")]
        public string Twitter { get; set; }

        [RegularExpression(@"^[(http(s)?):\\/\\/(www\\.)?a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]‌​{2,6}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)$", ErrorMessage = "You must enter a valid url.")]
        [Display(Name = "Facebook")]
        public string Facebook { get; set; }

        [RegularExpression(@"^[(http(s)?):\\/\\/(www\\.)?a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]‌​{2,6}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)$", ErrorMessage = "You must enter a valid url.")]
        [Display(Name = "Blog")]
        public string Blog { get; set; }

        [RegularExpression(@"^[(http(s)?):\\/\\/(www\\.)?a-zA-Z0-9@:%._\\+~#=]{2,256}\\.[a-z]‌​{2,6}\\b([-a-zA-Z0-9@:%_\\+.~#?&//=]*)$", ErrorMessage = "You must enter a valid url.")]
        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Job Title")]
        public string Title { get; set; }

        [Display(Name = "Profession")]
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