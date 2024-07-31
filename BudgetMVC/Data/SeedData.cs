﻿using Microsoft.EntityFrameworkCore;
using BudgetMVC.Models;
using static System.Net.WebRequestMethods;

namespace BudgetMVC.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        { 
            using(var context = new DataContext(
                serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if(context.Categories.Any())
                {
                    return;
                }
                context.Categories.AddRange(
                new Category
                {
                    ImageUrl = "https://img.icons8.com/clouds/100/hamburger.png",
                    Name = "Food",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                },
                new Category
                {
                    ImageUrl = "https://img.icons8.com/bubbles/50/bus.png",
                    Name = "Transportation",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                },
                new Category
                {
                    ImageUrl = "https://img.icons8.com/bubbles/50/cottage.png",
                    Name = "Housing",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                },
                new Category
                {
                    ImageUrl = "https://img.icons8.com/bubbles/50/maintenance.png",
                    Name = "Utilities",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                },
                new Category
                {
                    ImageUrl = "https://img.icons8.com/bubbles/50/netflix.png",
                    Name = "Subscriptions",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                },
                new Category
                {
                    ImageUrl = "https://img.icons8.com/clouds/100/hospital.png",
                    Name = "Healthcare",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                },
                new Category
                {
                    ImageUrl = "https://img.icons8.com/clouds/100/bank-card-back-side.png",
                    Name = "Personal expenses",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                },
                new Category
                {
                    ImageUrl = "https://img.icons8.com/clouds/100/bank.png",
                    Name = "Savings and investments",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                },
                new Category
                {
                    ImageUrl = "https://img.icons8.com/clouds/100/money-time.png",
                    Name = "Debt payment",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                },
                new Category
                {
                    ImageUrl = "https://img.icons8.com/clouds/100/more.png",
                    Name = "Miscellaneous expenses",
                    TotalValue = 0,
                    CurrencyCode = "",
                    CurrencyNativeSymbol = ""
                });
                context.SaveChanges();
            }
        }
    }
}
