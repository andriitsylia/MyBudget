using MyBudget.EF;
using MyBudget.Interfaces;
using MyBudget.Models;
using System.Collections.Generic;

namespace MyBudget.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly MyBudgetContext _context;

        public ExpenseRepository(MyBudgetContext context)
        {
            _context = context;
        }

        public IEnumerable<Expense> GetAll()
        {
            return _context.Expenses;
        }

        public Expense GetById(int id)
        {
            return _context.Expenses.Find(id);
        }
    }
}
