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
            var categories = _context.Categories.ToList();

            return categories;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);

            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);

            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);

            _context.SaveChanges();
        }
    }
}
