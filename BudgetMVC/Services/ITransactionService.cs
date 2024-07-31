using Microsoft.AspNetCore.Mvc;
using BudgetMVC.Data;
using BudgetMVC.Models;

namespace BudgetMVC.Services
{
    public interface ITransactionService
    {
        public List<Transaction> GetAllTransactions();
        public void AddTransaction(Transaction transaction);
        public void DeleteTransaction(Transaction transaction);
        public void UpdateTransaction(Transaction transaction);
    }
}
