using Entitis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategotyRepository : ICategotyRepository
    {
        AdeNetManageContext manageDbContext;

        public CategotyRepository(AdeNetManageContext manageDbContext)
        {
            this.manageDbContext = manageDbContext;
        }
        //public async Task<Category> AddCaterory(Category caterory)
        //{
        //    await manageDbContext.Categories.AddAsync(caterory);
        //    await manageDbContext.SaveChangesAsync();
        //    return caterory;

        //}
        //public async Task UpdateCategory(int id, Category categoryToUpdate)
        //{
        //    categoryToUpdate.Id = id;
        //    manageDbContext.Categories.Update(categoryToUpdate);
        //    await manageDbContext.SaveChangesAsync();


        //}

        public async Task<List<Category>> GetCategory()
        {
            return await manageDbContext.Categories.ToListAsync();
        }
        //public async Task DeleteCategory(int id, Category category)
        //{
        //    category.Id = id;
        //    manageDbContext.Categories.Remove(category);
        //    await manageDbContext.SaveChangesAsync();
        //}
        //public async Task<Category> GetCategoryById(int id)
        //{
        //    Category category = await manageDbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
        //    return category;

        //}
    }
}
    

