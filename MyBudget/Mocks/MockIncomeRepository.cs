using MyBudget.Interfaces;
using MyBudget.Models;
using System.Collections.Generic;
using System;

namespace MyBudget.Mocks
{
    public class MockIncomeRepository : IIncomeRepository
    {
        public void Create(Income income)
        {
            throw new NotImplementedException();
        }

        public void Delete(Income income)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Income> GetAll()
        {
            return new List<Income>()
            {
                new Income()
                {
                    Id = 0,
                    Date = new DateTime(2021, 10, 15),
                    IncomeType = new IncomeType() { Id = 0, Name = "Salary", Comment = "Main income" },
                    Sum = 10,
                    Comment = "Salary"
                },
                    new Income()
                {
                    Id = 1,
                    Date = new DateTime(2021, 11, 15),
                    IncomeType = new IncomeType() { Id = 1, Name = "Part-time job", Comment = "Additional money" },
                    Sum = 20,
                    Comment = "Part-time job"
                },
                    new Income()
                {
                    Id = 2,
                    Date = new DateTime(2021, 12, 15),
                    IncomeType = new IncomeType() { Id = 2, Name = "Royalty", Comment = "Excellent money" },
                    Sum = 30,
                    Comment = "Royalty"
                }
            };
        }

        public Income GetById(int id)
        {
            return new Income()
            {
                Id = id,
                Date = DateTime.Today,
                IncomeType = new IncomeType() { Id = 0, Name = "Salary", Comment = "Main income" },
                Sum = 10,
                Comment = "Salary"
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Income income)
        {
            throw new NotImplementedException();
        }
    }
}
