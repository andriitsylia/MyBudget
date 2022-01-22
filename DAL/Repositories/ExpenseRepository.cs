using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entities;
using DAL.Interfaces;
using DAL.EF;

namespace DAL.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly EF.MyBudgetContext _context;

        public ExpenseRepository(EF.MyBudgetContext context)
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

        public void Delete(Expense expense)
        {
            if (expense == null)
            {
                throw new ArgumentNullException(nameof(expense));
            }

            _context.Expenses.Remove(expense);
        }

        public IEnumerable<Expense> GetAll()
        {
            return _context.Expenses.Include(et => et.ExpenseType).ToList();
        }

        public Expense GetById(int id)
        {
            return _context.Expenses.Include(et => et.ExpenseType).FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Expense> GetByDate(DateTime beginDate, DateTime endDate)
        {
            return _context.Expenses.Where(i => beginDate <= i.Date && i.Date <= endDate)
                                    .Include(it => it.ExpenseType)
                                    .Select(i => i)
                                    .ToList();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void Update(Expense expense)
        {
            _context.Expenses.Update(expense);
        }
    }
}
