using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitis;
using Repository;
using DTO;
using Microsoft.Extensions.Logging;
using NLog;
namespace Services
{
    public class OrderService : IOrderService
    {
        IOrderRepository OrderRepository;
        IProductRepository productRepository;
        private readonly ILogger<UserRepository> _logger;
        public OrderService(IOrderRepository orderRepository,IProductRepository productRepository, ILogger<UserRepository> logger)
        {
            OrderRepository = orderRepository;
            this.productRepository = productRepository;
            _logger = logger;

        }
        public async Task<Order> AddOrder(Order order)
        {
            Order GoodOrder = await CheckSum(order);
            return await OrderRepository.AddOrder(order);
        }
        private async Task<Order> CheckSum(Order Order)
        {
            float sum = 0;
            foreach (var p in Order.OrderItems)
            {
                Product product = await productRepository.GetById(p.ProductId);
                sum += (float)product.Price;
            }
            if (Order.OrderSum != sum)
            {

                Order.OrderSum = sum;
                _logger.LogCritical("הכניס סכום בכוחות עצמו");
            }

            return Order;
        }
        public async Task<Order> GetOrderById(int id)
        {
            return await OrderRepository.GetOrderById(id);
        }
    }
}
