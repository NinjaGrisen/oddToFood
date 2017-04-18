using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RemeberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
