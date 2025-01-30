﻿using Microsoft.AspNetCore.Mvc;
using Services;
using Entitis;
using AutoMapper;
using DTO;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OurShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService OrderService;
        IMapper mapper;
        public OrderController(IOrderService orderService, IMapper mapper)
        {
            OrderService = orderService;
            this.mapper = mapper;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task<OrderDTO> Get(int id)
        {
            //return await OrderService.GetOrderById(id);

            Order order = await OrderService.GetOrderById(id);
            OrderDTO orderDTOs = mapper.Map<Order, OrderDTO>(order);
            return orderDTOs;

        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<Order> Post([FromBody] OrderPostDTO order)
        {

            //Order newOrder = ;
            return await OrderService.AddOrder(mapper.Map<OrderPostDTO, Order>(order));
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

