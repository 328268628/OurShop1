using Entitis;

namespace Services
{
    public interface ICategoryService
    {
        //Task<Category> AddCategory(Category category);
        //Task DeleteCategory(int id, Category category);
        Task<List<Category>> GetCategory();
        //Task<Category> GetCategoryById(int id);
        //Task UpdateCategory(int id, Category categoryToUpdate);
    }
}