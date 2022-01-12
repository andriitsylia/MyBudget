using MyBudget.Interfaces;
using MyBudget.Models;
using System.Collections.Generic;
using System;

namespace MyBudget.Mocks
{
    public class MockExpenseRepository : IExpenseRepository
    {
        public IEnumerable<Expense> GetAll()
        {
            return new List<Expense>()
            {
                new Expense()
                {
                    Id = 0,
                    Date = DateTime.Today,
                    ExpenseType = new ExpenseType() { Id = 0, Name = "Food", Comment = "Bread, Butter etc." },
                    Sum = 100,
                    Comment = "Food"
                },
                new Expense()
                {
                    Id = 1,
                    Date = DateTime.Today,
                    ExpenseType = new ExpenseType() { Id = 1, Name = "Beverages", Comment = "Water, Juice, Coca-Cola etc." },
                    Sum = 200,
                    Comment = "Beverages"
                },
                new Expense()
                {
                    Id = 2,
                    Date = DateTime.Today,
                    ExpenseType = new ExpenseType() { Id = 2, Name = "Medicines", Comment = "Panadol, Nurofen, Ibuprofen etc." },
                    Sum = 300,
                    Comment = "Medicines"
                }
            };
        }

        public Expense GetById(int id)
        {
            return new Expense()
            {
                Id = id,
                Date = DateTime.Today,
                ExpenseType = new ExpenseType() { Id = id, Name = "Food", Comment = "Bread, Butter etc." },
                Sum = 100,
                Comment = "Food"
            };
        }
    }
}
