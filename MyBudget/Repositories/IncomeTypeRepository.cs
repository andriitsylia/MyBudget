using MyBudget.Models;
using MyBudget.Interfaces;
using MyBudget.EF;
using System.Collections.Generic;

namespace MyBudget.Repositories
{
    public class IncomeTypeRepository : IIncomeTypeRepository
    {
        private readonly MyBudgetContext _context;

        public IncomeTypeRepository(MyBudgetContext context)
        {
            _context = context;
        }

        public IEnumerable<IncomeType> GetAll()
        {
            return _context.IncomeTypes;
        }

        public IncomeType GetById(int id)
        {
            return _context.IncomeTypes.Find(id);
        }
    }
}
