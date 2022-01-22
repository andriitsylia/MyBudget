using System;
using System.Collections.Generic;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IExpenseRepository
    {
        bool SaveChanges();
        IEnumerable<Expense> GetAll();
        Expense GetById(int id);
        IEnumerable<Expense> GetByDate(DateTime beginDate, DateTime endDate);
        void Create(Expense expense);
        void Update(Expense expense);
        void Delete(Expense expense);
    }
}
