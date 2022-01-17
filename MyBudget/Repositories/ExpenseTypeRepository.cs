using MyBudget.EF;
using MyBudget.Interfaces;
using MyBudget.Models;
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

        public IEnumerable<ExpenseType> GetAll()
        {
            return _context.ExpenseTypes.ToList();
        }

        public ExpenseType GetById(int id)
        {
            return _context.ExpenseTypes.FirstOrDefault(e => e.Id == id);
        }
    }
}
