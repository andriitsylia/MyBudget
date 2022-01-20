using MyBudget.EF;
using MyBudget.Interfaces;
using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBudget.Repositories
{
    public class ExpenseTypeRepository : IExpenseTypeRepository
    {
        private readonly MyBudgetContext _context;

        public ExpenseTypeRepository(MyBudgetContext context)
        {
            _context = context;
        }

        public void Create(ExpenseType expenseType)
        {
            if (expenseType == null)
            {
                throw new ArgumentNullException(nameof(expenseType));
            }

            _context.ExpenseTypes.Add(expenseType);
        }

        public IEnumerable<ExpenseType> GetAll()
        {
            return _context.ExpenseTypes.ToList();
        }

        public ExpenseType GetById(int id)
        {
            return _context.ExpenseTypes.FirstOrDefault(e => e.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void Update(ExpenseType expenseType)
        {
            _context.ExpenseTypes.Update(expenseType);
        }
    }
}
