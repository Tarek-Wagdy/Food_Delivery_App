using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Repositories
{
    public interface IOrderRepository
    {
        List<Order> getAll();
        List<Order> getAllByAddress(string address);
        Order getById(int id);
        void insert(Order order);
        void update(int id,Order order);
        void delete(int id);
    }
}
