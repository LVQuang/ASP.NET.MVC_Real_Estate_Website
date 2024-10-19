using System;
using System.ComponentModel.DataAnnotations;

namespace Real_Estate_Website.DTO.Request
{
    public class Register
    {
        [Required(ErrorMessage = "Username can not be empty")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password can not be empty")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password can not be empty")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password does not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email can not be empty")]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
    }
}