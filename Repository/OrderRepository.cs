using AutoMapper;
using DTO;
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
        IMapper _mapper;
        public OrderRepository(IMapper mapper,AdeNetManageContext manageDbContext)
        {
            _mapper = mapper;
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
            return await manageDbContext.Orders.Include(p => p.User).Include(o => o.OrderItems).FirstOrDefaultAsync(order => order.Id == id);

        }
    }
}
