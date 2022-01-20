using MyBudget.Models;
using System.Collections.Generic;

namespace MyBudget.Interfaces
{
    public interface IIncomeRepository
    {
        bool SaveChanges();
        IEnumerable<Income> GetAll();
        Income GetById(int id);
        void Create(Income income);
        void Update(Income income);
    }
}
