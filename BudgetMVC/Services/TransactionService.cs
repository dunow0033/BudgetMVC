using BudgetMVC.Models;
using BudgetMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace BudgetMVC.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly DataContext _context;
        public TransactionService(DataContext context)
        {
            _context = context;
        }
        public List<Models.Transaction> GetAllTransactions()
        {
            var transactions = _context.Transactions.ToList();

            return transactions;
        }
        public void AddTransaction(Models.Transaction transaction)
        {
            _context.Transactions.Add(transaction);

            _context.SaveChanges();
        }

        public void DeleteTransaction(Models.Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public void UpdateTransaction(Models.Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
