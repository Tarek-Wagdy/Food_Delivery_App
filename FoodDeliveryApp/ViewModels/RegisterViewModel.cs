using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string UserClass { get; set; }

    }
}
