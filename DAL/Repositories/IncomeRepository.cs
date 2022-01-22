using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entities;
using DAL.Interfaces;
using DAL.EF;

namespace DAL.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly EF.MyBudgetContext _context;

        public IncomeRepository(EF.MyBudgetContext context)
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

        public void Delete(Income income)
        {
            if (income == null)
            {
                throw new ArgumentNullException(nameof(income));
            }

            _context.Incomes.Remove(income);
        }

        public IEnumerable<Income> GetAll()
        {
            return _context.Incomes.Include(it => it.IncomeType).ToList();
        }

        public Income GetById(int id)
        {
            return _context.Incomes.Include(it => it.IncomeType).FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Income> GetByDate(DateTime beginDate, DateTime endDate)
        {
            return _context.Incomes.Where(i => beginDate <= i.Date && i.Date <= endDate)
                                   .Include(it => it.IncomeType)
                                   .Select(i => i)
                                   .ToList();
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
