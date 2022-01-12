using MyBudget.Models;
using System.Collections.Generic;

namespace MyBudget.Interfaces
{
    public interface IIncomeTypeRepository
    {
        IEnumerable<IncomeType> GetAll();
        IncomeType GetById(int id);

    }
}
