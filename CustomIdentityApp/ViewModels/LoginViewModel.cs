using System.ComponentModel.DataAnnotations;

namespace CustomIdentityApp.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remeber?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}