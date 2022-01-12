using MyBudget.Models;
using System.Collections.Generic;

namespace MyBudget.Interfaces
{
    public interface IIncomeRepository
    {
        IEnumerable<Income> GetAll();
        Income GetById(int id);
    }
}
