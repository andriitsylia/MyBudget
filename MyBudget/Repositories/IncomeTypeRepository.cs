using MyBudget.Models;
using MyBudget.Interfaces;
using MyBudget.EF;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MyBudget.Repositories
{
    public class IncomeTypeRepository : IIncomeTypeRepository
    {
        private readonly MyBudgetContext _context;

        public IncomeTypeRepository(MyBudgetContext context)
        {
            _context = context;
        }

        public void Create(IncomeType incomeType)
        {
            if (incomeType == null)
            {
                throw new ArgumentNullException(nameof(incomeType));
            }

            _context.IncomeTypes.Add(incomeType);
        }

        public IEnumerable<IncomeType> GetAll()
        {
            return _context.IncomeTypes.ToList();
        }

        public IncomeType GetById(int id)
        {
            return _context.IncomeTypes.FirstOrDefault(i => i.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void Update(IncomeType incomeType)
        {
            _context.IncomeTypes.Update(incomeType);
        }
    }
}
