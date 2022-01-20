using System.Collections.Generic;
using MyBudget.Models;

namespace MyBudget.Interfaces
{
    public interface IExpenseRepository
    {
        bool SaveChanges();
        IEnumerable<Expense> GetAll();
        Expense GetById(int id);
        void Create(Expense expense);
        void Update(Expense expense);
    }
}
