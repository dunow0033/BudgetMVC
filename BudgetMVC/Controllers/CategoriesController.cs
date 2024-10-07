using BudgetMVC.Data;
using BudgetMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetMVC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DataContext _context;
        private readonly CategoryService _categoryService;
        private readonly TransactionService _transactionService;

        public CategoriesController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index(string timeline = "", string searchStringOne = "", string searchStringTwo = "")
        {
            var categories = _categoryService.GetAllCategories();
            var transactions = _transactionService.GetAllTransactions();

            if(!string.IsNullOrEmpty(timeline))
            {
                DateTime firstDayOfTheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime lastDayOfTheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

                DateTime firstDayOfThreeMonthsAgoMonth = new DateTime(DateTime.Now.AddMonths(-3).Year, DateTime.Now.AddMonths(-3).Month, 1);
                DateTime lastDayOfThreeMonthsAgoMonth = new DateTime(DateTime.Now.AddMonths(-3).Year, DateTime.Now.AddMonths(-3).Month, DateTime.DaysInMonth(DateTime.Now.AddMonths(-3).Year, DateTime.Now.AddMonths(-3).Month));

                DateTime firstDayOfSixMonthsAgoMonth = new DateTime(DateTime.Now.AddMonths(-6).Year, DateTime.Now.AddMonths(-6).Month, 1);
                DateTime lastDayOfSixMonthsAgoMonth = new DateTime(DateTime.Now.AddMonths(-6).Year, DateTime.Now.AddMonths(-6).Month, DateTime.DaysInMonth(DateTime.Now.AddMonths(-6).Year, DateTime.Now.AddMonths(-6).Month));

                DateTime firstDayOfTLastYearMonth = new DateTime(DateTime.Now.AddYears(-1).Year, DateTime.Now.AddYears(-1).Month, 1);
                DateTime lastDayOfLastYearMonth = new DateTime(DateTime.Now.AddYears(-1).Year, DateTime.Now.AddYears(-1).Month, DateTime.DaysInMonth(DateTime.Now.AddYears(-1).Year, DateTime.Now.AddYears(-1).Month));

                switch(timeline)
                {
                    case "LastMonth":
                        transactions = transactions = transactions.Where(x)
                }
            }

            return View();
        }
    }
}
