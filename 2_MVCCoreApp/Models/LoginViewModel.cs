using System.ComponentModel;

namespace _2_MVCCoreApp.Models
{
    public class LoginViewModel
    {
        [DisplayName("Registered Email")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
