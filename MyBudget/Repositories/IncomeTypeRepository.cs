using MyBudget.Models;
using MyBudget.Interfaces;
using MyBudget.EF;
using System.Collections.Generic;
using System.Linq;

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
            return _context.IncomeTypes.ToList();
        }

        public IncomeType GetById(int id)
        {
            return _context.IncomeTypes.FirstOrDefault(i => i.Id == id);
        }
    }
}
