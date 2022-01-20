using MyBudget.Interfaces;
using MyBudget.Models;
using System.Collections.Generic;

namespace MyBudget.Mocks
{
    public class MockIncomeTypeRepository : IIncomeTypeRepository
    {
        public void Create(IncomeType incomeType)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(IncomeType incomeType)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IncomeType> GetAll()
        {
            return new List<IncomeType>()
            {
                new IncomeType() { Id = 0, Name = "Salary", Comment = "Main money" },
                new IncomeType() { Id = 1, Name = "Part-time job", Comment = "Additional money" },
                new IncomeType() { Id = 2, Name = "Royalty", Comment = "Excellent money" }
            };
        }

        public IncomeType GetById(int id)
        {
            return new IncomeType() { Id = 0, Name = "Salary", Comment = "Main income" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(IncomeType incomeType)
        {
            throw new System.NotImplementedException();
        }
    }
}
