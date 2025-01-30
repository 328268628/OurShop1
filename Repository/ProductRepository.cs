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
        //public async Task<List<Product>> GetProduct()
        //{
        //    return await manageDbContext.Products.Include(x=>x.Category).ToListAsync();
        //}
        public async Task<List<Product>> GetProduct( string? desc, int? minPrice, int? maxPrice, int?[] categoryIds)
        {
            var query = manageDbContext.Products.Where(product =>
              (desc == null ? (true) : (product.Description.Contains(desc)))
              && ((minPrice == null) ? (true) : (product.Price >= minPrice))
              && ((maxPrice == null) ? (true) : (product.Price <= maxPrice))
              && ((categoryIds.Length == 0) ? (true) : (categoryIds.Contains(product.CategoryId))))
              .OrderBy(product => product.Price);
            List<Product> products = await query.Include(c => c.Category).ToListAsync();
            return products;
            //return await manageDbContext.Products.Include(a => a.Category).ToListAsync();
        }

    }
}
