using System.ComponentModel.DataAnnotations;

namespace Agriculture_Presentation.Models
{
    public class UserUpdateViewModel
    {
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }
    }
}
