namespace FoodDeliveryApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalCost { get; set; }
        public string Address { get; set; }
        public Order()
        {
            OrderDate = DateTime.Now;
        }
    }
}
