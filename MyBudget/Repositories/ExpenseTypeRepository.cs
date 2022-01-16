using MyBudget.EF;
using MyBudget.Interfaces;
using MyBudget.Models;
using System.Collections.Generic;

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
            return _context.ExpenseTypes;
        }

        public ExpenseType GetById(int id)
        {
            return _context.ExpenseTypes.Find(id);
        }
    }
}
