using Entitis;

namespace Repository
{
    public interface ICategotyRepository
    {
        //Task<Category> AddCaterory(Category caterory);
        //Task DeleteCategory(int id, Category category);
        Task<List<Category>> GetCategory();
        //Task<Category> GetCategoryById(int id);
        //Task UpdateCategory(int id, Category categoryToUpdate);
    }
}