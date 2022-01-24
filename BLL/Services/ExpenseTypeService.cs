using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ExpenseTypeService :IBudgetService<ExpenseTypeDto>
    {
        private readonly IBudgetRepository<ExpenseType> _repository;
        private readonly IMapper _mapper;

        public ExpenseTypeService(IBudgetRepository<ExpenseType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(ExpenseTypeDto item)
        {
            var expenseTypeItem = _mapper.Map<ExpenseType>(item);

            _repository.Create(expenseTypeItem);
            _repository.SaveChanges();
        }

        public IEnumerable<ExpenseTypeDto> GetAll()
        {
            var expenseTypeItems = _repository.Get();

            return _mapper.Map<IEnumerable<ExpenseTypeDto>>(expenseTypeItems);
        }

        public ExpenseTypeDto GetById(int id)
        {
            var expenseTypeItem = _repository.GetById(id);

            return _mapper.Map<ExpenseTypeDto>(expenseTypeItem);
        }

        public bool Update(int id, ExpenseTypeDto item)
        {
            var expenseTypeItem = _repository.GetById(id);

            if (expenseTypeItem == null)
            {
                return false;
            }

            _mapper.Map(item, expenseTypeItem);
            _repository.Update(expenseTypeItem);
            _repository.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var expenseTypeItem = _repository.GetById(id);

            if (expenseTypeItem == null)
            {
                return false;
            }

            _repository.Delete(expenseTypeItem);
            _repository.SaveChanges();

            return true;
        }
    }
}
