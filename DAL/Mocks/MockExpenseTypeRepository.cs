using System.Collections.Generic;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Mocks
{
    public class MockExpenseTypeRepository : IExpenseTypeRepository
    {
        public void Create(ExpenseType expenseType)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(ExpenseType expenseType)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ExpenseType> GetAll()
        {
            return new List<ExpenseType>()
            {
                new ExpenseType() { Id = 0, Name = "Food", Comment = "Bread, Butter, Milk etc." },
                new ExpenseType() { Id = 1, Name = "Beverages", Comment = "Water, Juice, Coca-Cola etc." },
                new ExpenseType() { Id = 2, Name = "Medicines", Comment = "Panadol, Nurofen, Ibuprofen etc." }
            };
        }

        public ExpenseType GetById(int id)
        {
            return new ExpenseType() { Id = 0, Name = "Food", Comment = "Bread, Butter etc." };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(ExpenseType expenseType)
        {
            throw new System.NotImplementedException();
        }
    }
}
