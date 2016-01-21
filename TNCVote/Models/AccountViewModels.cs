using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace TNCVote.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    class Country
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }



    public class YearRangeAttribute : RangeAttribute
    {
        public YearRangeAttribute()
          : base( DateTime.Now.AddYears(-130).Year, DateTime.Now.AddYears(-18).Year)
        {
           
        }
    }

  

    public static class ValidateDayInMonth
    {
        public static bool IsValid(int birthYear, int birthMonth, int birthDay)
        {
            bool flag = false;
            if (birthDay > 0 && birthDay <= DateTime.DaysInMonth(birthYear,birthMonth))
            {
                flag = true;
            }
            return flag;


        }

      
    }



    public class RegisterViewModel
    {

        public const int year =18;

       
        [Required]
        [StringLength(40,  ErrorMessage = "First name is too long. Please shorten.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

       
        [Required]
        [StringLength(50, ErrorMessage = "Last name too long. Please shorten.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Citizenship Country")]
        public string Country { get; set; }

        [Range(1, 31, ErrorMessage = "Please enter valid birth day.")]
        [Required]
        [Display(Name = "Birth Day")]
        public int BirthDay { get; set; }

        [Range(1, 12, ErrorMessage = "Please enter valid birth month.")]
        [Required]
        [Display(Name = "Birth Month")]
        public int BirthMonth { get; set; }

        [YearRange(ErrorMessage = "Please enter valid birth year. You must be over 18 years old to register.")]
        [Required]
        [Display(Name = "Birth Year")]
        public int BirthYear { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [MaxLength(10, ErrorMessage = "Please select a valid city.")]
        [Display(Name = "City of Residence")]
        public string City { get; set; }

        [MaxLength(10, ErrorMessage = "Please select a valid county.")]
        [Display(Name = "County of Residence")]
        public string County { get; set; }

        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Postal Code")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [MaxLength(10, ErrorMessage = "Please select a valid sex.")]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [MaxLength(40, ErrorMessage = "Please select a valid income range.")]
        [Display(Name = "Income Range")]
        public string IncomeRange { get; set; }

        [MaxLength(40, ErrorMessage = "Please select a valid educational attainment.")]
        [Display(Name = "Education")]
        public string Education { get; set; }

        [MaxLength(40, ErrorMessage = "Please select a valid marital status.")]
        [Display(Name = "Married")]
        public string Married { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

        [Url]
        [Display(Name = "Twitter")]
        public string Twitter { get; set; }

        [Url]
        [Display(Name = "Facebook")]
        public string Facebook { get; set; }

        [Url]
        [Display(Name = "Blog")]
        public string Blog { get; set; }

        [Url]
        [Display(Name = "Website")]
        public string Website { get; set; }

        [MaxLength(100, ErrorMessage = "Your title is too long. Please abbreviate")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [MaxLength(100, ErrorMessage = "Your profession name is too long. Please abbreviate")]
        [Display(Name = "Profession")]
        public string Profession { get; set; }
         
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
