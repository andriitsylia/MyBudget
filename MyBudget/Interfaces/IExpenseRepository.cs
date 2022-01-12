using System.Collections.Generic;
using MyBudget.Models;

namespace MyBudget.Interfaces
{
    public interface IExpenseRepository
    {
        IEnumerable<Expense> GetAll();
        Expense GetById(int id);
    }
}
