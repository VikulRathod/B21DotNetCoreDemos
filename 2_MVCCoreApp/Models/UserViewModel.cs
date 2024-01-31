using _2_MVCCoreApp.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _2_MVCCoreApp.Models
{
    public class UserViewModel
    {
        [DisplayName("User Id")]
        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Name should be 2 to 10 characters long")]
        public string Name { get; set; }

        [Required]
        [Range(typeof(int), "1", "150", ErrorMessage = "Age should be between 1 to 150")]
        [CustomEvenNumberValidationAttribute(ErrorMessage = "Please enter age in even number only")]
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [DisplayName("Confirm Email")]
        [Required]
        [Compare("Email", ErrorMessage = "Email and Confirm Email should be same")]
        public string ConfirmEmail { get; set; }

        [DisplayName("Date Of Birth")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format")]
        public DateTime DateOfBirth { get; set; }
    }
}
