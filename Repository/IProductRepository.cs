using Entitis;

namespace Repository
{
    public interface IProductRepository
    {
        //Task<Product> AddProduct(Product product);
        //Task DeleteProduct(int id, Product product);
        Task<List<Product>> GetProduct( string? desc, int? minPrice, int? maxPrice, int?[] categoryIds);
        

    }
}