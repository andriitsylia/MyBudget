using MyBudget.Models;
using System.Collections.Generic;

namespace MyBudget.Interfaces
{
    public interface IExpenseTypeRepository
    {
        IEnumerable<ExpenseType> GetAll();
        ExpenseType GetById(int id);
    }
}
