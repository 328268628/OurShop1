using Entitis;
namespace DTO
{
    public record OrderDTO(int Id, DateTime? OrderDate, double OrderSum, ICollection<OrderItem> OrderItems);
}