using System.Collections.Generic;
using DAL.Entities;

namespace DAL.Interfaces
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
