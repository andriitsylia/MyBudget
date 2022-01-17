
using Microsoft.EntityFrameworkCore;
using MyBudget.EF;
using MyBudget.Interfaces;
using MyBudget.Models;
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

        public IEnumerable<Income> GetAll()
        {
            return _context.Incomes.Include(it => it.IncomeType).ToList();
        }

        public Income GetById(int id)
        {
            return _context.Incomes.Include(it => it.IncomeType).FirstOrDefault(i => i.Id == id);
        }
    }
}
