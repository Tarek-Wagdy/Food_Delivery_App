using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.Models
{
    public class ApplicationUser:IdentityUser<int>
    {
        [Required]
        public string UserClass { get; set; }
    }
}
