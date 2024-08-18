using System.ComponentModel.DataAnnotations;

namespace Agriculture_Presentation.Models
{
    public class UserRegisterViewModel
    {
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }
    }
}
