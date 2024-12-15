using Entitis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepository : IOrderRepository
    {
        AdeNetManageContext manageDbContext;

        public OrderRepository(AdeNetManageContext manageDbContext)
        {
            this.manageDbContext = manageDbContext;
        }

        public async Task<Order> AddOrder(Order order)
        {
            await manageDbContext.Orders.AddAsync(order);
            await manageDbContext.SaveChangesAsync();
            return order;

        }
        public async Task<Order> GetOrderById(int id)
        {
            Order order = await manageDbContext.Orders.Include(x=>x.OrderItems).FirstOrDefaultAsync(o => o.Id == id);
            return order;

        }
    }
}
