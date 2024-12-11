using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitis;
using Repository;
namespace Services
{
    public class CategoryService : ICategoryService
    {
        ICategotyRepository categotyRepository;

        public CategoryService(ICategotyRepository categotyRepository)
        {
            this.categotyRepository = categotyRepository;
        }
        //public async Task<Category> AddCategory(Category category)
        //{
        //    return await categotyRepository.AddCaterory(category);
        //}

        //public async Task UpdateCategory(int id, Category categoryToUpdate)
        //{

        //    await categotyRepository.UpdateCategory(id, categoryToUpdate);

        //}
        public async Task<List<Category>> GetCategory()
        {

            return await categotyRepository.GetCategory();

        }

        //public async Task DeleteCategory(int id, Category category)
        //{

        //    await categotyRepository.DeleteCategory(id, category);

        //}
        //public async Task<Category> GetCategoryById(int id)
        //{
        //    return await categotyRepository.GetCategoryById(id);
        //}
    }
}
