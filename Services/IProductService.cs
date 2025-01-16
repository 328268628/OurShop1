using Entitis;

namespace Services
{
    public interface IProductService
    {
        //Task<Product> AddProduct(Product product);
        //Task DeleteProducts(int id, Product product);
        Task<List<Product>> GetProducts( string? desc, int? minPrice, int? maxPrice, int?[] categoryIds);
        //Task UpdateProduct(int id, Product productToUpdate);
    }
}