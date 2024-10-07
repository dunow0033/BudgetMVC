using BudgetMVC.Models;

namespace BudgetMVC.Services
{
    public interface ICategoryService
    {
        public List<Category> GetAllCategories();
        public void AddCategory(Category category);
        public void DeleteCategory(Category category);
        public void UpdateCategory(Category category);
    }
}
