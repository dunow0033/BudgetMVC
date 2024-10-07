using BudgetMVC.Models;
using BudgetMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace BudgetMVC.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly DataContext _context;
        public TransactionService(DataContext context)
        {
            _context = context;
        }
        public List<Transaction> GetAllTransactions()
        {
            var transactions = _context.Transactions.ToList();

            return transactions;
        }
        public void AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);

            _context.SaveChanges();
        }

        public void DeleteTransaction(Transaction transaction)
        {
            _context.Transactions.Remove(transaction);

            _context.SaveChanges();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _context.Transactions.Update(transaction);

            _context.SaveChanges();
        }
    }
}
