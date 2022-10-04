using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryApp.Models
{
    public class OrderItem
    {
        [Column(Order = 0), Key, ForeignKey("order")]
        public int OrderId { get; set; }
        [Column(Order = 1), Key, ForeignKey("item")]
        public int ItemId { get; set; }
        public int quantity { get; set; }
        public virtual Order? order { get; set; }
        public virtual Item? item { get; set; }
    }
}
