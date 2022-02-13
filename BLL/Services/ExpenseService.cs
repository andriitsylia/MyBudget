using AutoMapper;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using DTO.Expense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;

namespace BLL.Services
{
    public class ExpenseService : IBudgetService<ExpenseDto>, IByDateService<ExpenseDto>
    {
        private readonly IBudgetRepository<Expense> _repository;
        private readonly IMapper _mapper;

        public ExpenseService(IBudgetRepository<Expense> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(ExpenseDto item)
        {
            var expenseItem = _mapper.Map<Expense>(item);

            _repository.Create(expenseItem);
            _repository.SaveChanges();
        }

        public IEnumerable<ExpenseDto> GetAll()
        {
            var expenseItems = _repository.Get(includeProperties: "ExpenseType");

            return _mapper.Map<IEnumerable<ExpenseDto>>(expenseItems);
        }

        public ExpenseDto GetById(int id)
        {
            //var expenseItem = _repository.GetById(id);
            var expenseItem = _repository.Get(filter: e => e.Id == id, includeProperties: "ExpenseType").Single();

            return _mapper.Map<ExpenseDto>(expenseItem);
        }

        public bool Update(/*int id, */ExpenseDto item)
        {
            var expenseItem = _repository.GetById(/*id*/item.Id);

            if (expenseItem == null)
            {
                return false;
            }

            _mapper.Map(item, expenseItem);
            _repository.Update(expenseItem);
            _repository.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var expenseItem = _repository.GetById(id);

            if (expenseItem == null)
            {
                return false;
            }

            _repository.Delete(expenseItem);
            _repository.SaveChanges();

            return true;
        }

        public IEnumerable<ExpenseDto> GetByDate(DateTime date)
        {
            var expenseItems = _repository.Get(filter: i => i.Date == date, includeProperties:"ExpenseType");

            return _mapper.Map<IEnumerable<ExpenseDto>>(expenseItems);
        }

        public IEnumerable<ExpenseDto> GetByDateInterval(DateTime beginDate, DateTime endDate)
        {
            var expenseItems = _repository.Get(filter: i => beginDate <= i.Date && i.Date <= endDate, includeProperties: "ExpenseType");

            return _mapper.Map<IEnumerable<ExpenseDto>>(expenseItems);
        }
    }
}
