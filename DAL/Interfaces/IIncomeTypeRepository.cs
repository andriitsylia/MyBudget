using System.Collections.Generic;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IIncomeTypeRepository
    {
        bool SaveChanges();
        IEnumerable<IncomeType> GetAll();
        IncomeType GetById(int id);
        void Create(IncomeType incomeType);
        void Update(IncomeType incomeType);
        void Delete(IncomeType incomeType);

    }
}
