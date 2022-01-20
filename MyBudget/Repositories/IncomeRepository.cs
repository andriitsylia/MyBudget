
using Microsoft.EntityFrameworkCore;
using MyBudget.EF;
using MyBudget.Interfaces;
using MyBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBudget.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly MyBudgetContext _context;

        public IncomeRepository(MyBudgetContext context)
        {
            _context = context;
        }

        public void Create(Income income)
        {
            if (income == null)
            {
                throw new ArgumentNullException(nameof(income));
            }

            _context.Incomes.Add(income);
        }

        public IEnumerable<Income> GetAll()
        {
            return _context.Incomes.Include(it => it.IncomeType).ToList();
        }

        public Income GetById(int id)
        {
            return _context.Incomes.Include(it => it.IncomeType).FirstOrDefault(i => i.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void Update(Income income)
        {
            _context.Incomes.Update(income);
        }
    }
}
