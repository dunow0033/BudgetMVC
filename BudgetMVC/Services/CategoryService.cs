using BudgetMVC.Data;
using BudgetMVC.Models;

namespace BudgetMVC.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        List<Category> ICategoryService.GetAllCategories()
        {
            throw new NotImplementedException();
        }

        void ICategoryService.AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        void ICategoryService.DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        void ICategoryService.UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
