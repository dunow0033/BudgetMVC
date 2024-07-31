﻿namespace BudgetMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public decimal TotalValue { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyNativeSymbol { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
