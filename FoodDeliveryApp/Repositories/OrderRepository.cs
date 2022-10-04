using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        Entity context;
        public OrderRepository(Entity context)
        {
            this.context = context;
        }

        public List<Order> getAll()
        {
            List<Order> orders = context.orders.ToList();
            return orders;
        }
        public List<Order> getAllByAddress(string address)
        {
            List<Order> orders = context.orders.Where(e=>e.Address==address).ToList();
            return orders;
        }

        public Order getById(int id)
        {
            Order order=context.orders.FirstOrDefault(o => o.Id == id);
            return order;
        }

        public void insert(Order order)
        {
            context.orders.Add(order);
            context.SaveChanges();
        }

        public void update(int id, Order order)
        {
            Order oldOrder =getById(id);
            oldOrder.Address = order.Address;
            oldOrder.TotalCost=order.TotalCost;
            context.SaveChanges();
        }
        public void delete(int id)
        {
            Order order = getById(id);
            context.orders.Remove(order);
            context.SaveChanges();
        }
    }
}
