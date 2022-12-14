using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
