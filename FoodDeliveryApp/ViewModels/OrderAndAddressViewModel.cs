using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.ViewModels
{
    public class OrderAndAddressViewModel
    {
        public List<Order> orders { get; set; }
        public List<string> addresses { get; set; }
    }
}
