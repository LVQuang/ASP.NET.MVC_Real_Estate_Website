using System.ComponentModel.DataAnnotations;

namespace Real_Estate_Website.DTO.Request
{
    public class LogIn
    {
        [Required(ErrorMessage = "Username can not be empty")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password can not be empty")]
        public string Password { get; set; }
    }
}