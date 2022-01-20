using MyBudget.Models;
using System.Collections.Generic;

namespace MyBudget.Interfaces
{
    public interface IExpenseTypeRepository
    {
        bool SaveChanges();
        IEnumerable<ExpenseType> GetAll();
        ExpenseType GetById(int id);
        void Create(ExpenseType expenseType);
        void Update(ExpenseType expenseType);
        void Delete(ExpenseType expenseType);
    }
}
