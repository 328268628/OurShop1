using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitis;
using Repository;

namespace Services
{
    public class ProductService : IProductService
    {
        IProductRepository productRepository;

        public ProductService(IProductRepository iproductRepository)
        {
            productRepository = iproductRepository;
        }
        //public async Task<Product> AddProduct(Product product)
        //{
        //    return await productRepository.AddProduct(product);
        //}

        //public async Task UpdateProduct(int id, Product productToUpdate)
        //{

        //    await productRepository.UpdateProduct(id, productToUpdate);

        //}
        public async Task<List<Product>> GetProducts(string? desc, int? minPrice, int? maxPrice, int?[] categoryIds)
        {

            return await productRepository.GetProduct( desc, minPrice, maxPrice, categoryIds);

        }

        //public async Task DeleteProducts(int id, Product product)
        //{

        //    await productRepository.DeleteProduct(id, product);

        //}
    }
}
