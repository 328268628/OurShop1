using Entitis;
namespace DTO
{
    public record OrderDTO(int Id, DateOnly Date, string UserFirstName, int? Sum);

    public record OrderPostDTO(int UserId, DateOnly Date,double Sum, List<OrderItemDTO> OrderItems);
}