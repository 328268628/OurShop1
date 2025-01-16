using Entitis;
using DTO;
namespace Repository
{
    public interface IOrderRepository
    {
        Task<Order> AddOrder(Order order);
        Task<Order> GetOrderById(int id);
    }
}