using Entitis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        AdeNetManageContext manageDbContext;

        public ProductRepository(AdeNetManageContext manageDbContext)
        {
            this.manageDbContext = manageDbContext;
        }

        //public async Task<Product> AddProduct(Product product)
        //{
        //    await manageDbContext.Products.AddAsync(product);
        //    await manageDbContext.SaveChangesAsync();
        //    return product;

        //}
        //public async Task UpdateProduct(int id, Product productToUpdate)
        //{
        //    productToUpdate.Id = id;
        //    manageDbContext.Products.Update(productToUpdate);
        //    await manageDbContext.SaveChangesAsync();


        //}
        public async Task<List<Product>> GetProduct()
        {
            return await manageDbContext.Products.Include(x=>x.Category).ToListAsync();
        }
        //public async Task DeleteProduct(int id, Product product)
        //{
        //    product.Id = id;
        //    manageDbContext.Products.Remove(product);
        //    await manageDbContext.SaveChangesAsync();
        //}
    }
}
