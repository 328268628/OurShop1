using Entitis;
namespace DTO
{
    public record OrderDTO(int Id, DateOnly OrderDate, string UserFirstName, int? OrderSum);

    public record OrderPostDTO(int UserId, DateOnly? OrderDate,double? OrderSum, ICollection<OrderItemDTO> OrderItems);
}