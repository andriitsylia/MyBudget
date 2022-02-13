using AutoMapper;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using DTO.Income;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;

namespace BLL.Services
{
    public class IncomeService : IBudgetService<IncomeDto>, IByDateService<IncomeDto>
    {
        private readonly IBudgetRepository<Income> _repository;
        private readonly IMapper _mapper;

        public IncomeService(IBudgetRepository<Income> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(IncomeDto item)
        {
            var incomeItem = _mapper.Map<Income>(item);

            _repository.Create(incomeItem);
            _repository.SaveChanges();
        }

        public IEnumerable<IncomeDto> GetAll()
        {
            var incomeItems = _repository.Get(includeProperties: "IncomeType");

            return _mapper.Map<IEnumerable<IncomeDto>>(incomeItems);
        }

        public IncomeDto GetById(int id)
        {
            //var incomeItem = _repository.GetById(id);
            var incomeItem = _repository.Get(filter: i => i.Id == id, includeProperties: "IncomeType").Single();

            return _mapper.Map<IncomeDto>(incomeItem);
        }

        public bool Update(/*int id, */IncomeDto item)
        {
            var incomeItem = _repository.GetById(/*id*/item.Id);

            if (incomeItem == null)
            {
                return false;
            }

            _mapper.Map(item, incomeItem);
            _repository.Update(incomeItem);
            _repository.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var incomeItem = _repository.GetById(id);

            if (incomeItem == null)
            {
                return false;
            }

            _repository.Delete(incomeItem);
            _repository.SaveChanges();

            return true;
        }

        public IEnumerable<IncomeDto> GetByDate(DateTime date)
        {
            var incomeItems = _repository.Get(filter: i => i.Date == date, includeProperties: "IncomeType");

            return _mapper.Map<IEnumerable<IncomeDto>>(incomeItems);
        }

        public IEnumerable<IncomeDto> GetByDateInterval(DateTime beginDate, DateTime endDate)
        {
            var incomeItems = _repository.Get(filter: i => beginDate <= i.Date && i.Date <= endDate, includeProperties: "IncomeType");

            return _mapper.Map<IEnumerable<IncomeDto>>(incomeItems);
        }
    }
}
