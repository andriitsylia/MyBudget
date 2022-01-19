using Microsoft.EntityFrameworkCore;
using MyBudget.EF;
using MyBudget.Interfaces;
using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBudget.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly MyBudgetContext _context;

        public ExpenseRepository(MyBudgetContext context)
        {
            _context = context;
        }

        public void Create(Expense expense)
        {
            if (expense == null)
            {
                throw new ArgumentNullException(nameof(expense));
            }

            _context.Expenses.Add(expense);
        }

        public IEnumerable<Expense> GetAll()
        {
            return _context.Expenses.Include(et => et.ExpenseType).ToList();
        }

        public Expense GetById(int id)
        {
            return _context.Expenses.Include(et => et.ExpenseType).FirstOrDefault(e => e.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
