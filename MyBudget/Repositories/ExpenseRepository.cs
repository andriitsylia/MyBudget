using Microsoft.EntityFrameworkCore;
using MyBudget.EF;
using MyBudget.Interfaces;
using MyBudget.Models;
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

        public IEnumerable<Expense> GetAll()
        {
            return _context.Expenses.Include(et => et.ExpenseType).ToList();
        }

        public Expense GetById(int id)
        {
            return _context.Expenses.Include(et => et.ExpenseType).FirstOrDefault(e => e.Id == id);
        }
    }
}
