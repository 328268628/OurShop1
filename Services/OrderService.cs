using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitis;
using Repository;
using DTO;
namespace Services
{
    public class OrderService : IOrderService
    {
        IOrderRepository OrderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }
        public async Task<Order> AddOrder(Order order)
        {
            return await OrderRepository.AddOrder(order);
        }
        public async Task<Order> GetOrderById(int id)
        {
            return await OrderRepository.GetOrderById(id);
        }
    }
}
