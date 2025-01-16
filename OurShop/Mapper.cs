using AutoMapper;
using Entitis;
using DTO;
namespace OurShop
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<User, UserDTO>();
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderPostDTO, Order>();
            CreateMap<OrderItem, OrderItemDTO>();
            CreateMap<OrderItemDTO, OrderItem>();
        }
    }
}
