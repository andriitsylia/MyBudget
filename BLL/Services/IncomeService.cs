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
    public class IncomeService : IMyBudgetService<IncomeDto>, IDateService<IncomeDto>
    {
        private readonly IMyBudgetRepository<Income> _repository;
        private readonly IMapper _mapper;

        public IncomeService(IMyBudgetRepository<Income> repository, IMapper mapper)
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
            var incomeItems = _repository.Get();

            return _mapper.Map<IEnumerable<IncomeDto>>(incomeItems);
        }

        public IncomeDto GetById(int id)
        {
            var incomeItems = _repository.GetById(id);

            return _mapper.Map<IncomeDto>(incomeItems);
        }

        public bool Update(int id, IncomeDto item)
        {
            var incomeItem = _repository.GetById(id);

            if (incomeItem == null)
            {
                return false;
            }
            item.Id = id; // !!!!! костыль !!!!!
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
            var incomeItems = _repository.Get(filter: i => i.Date == date);

            return _mapper.Map<IEnumerable<IncomeDto>>(incomeItems);
        }

        public IEnumerable<IncomeDto> GetByDateInterval(DateTime beginDate, DateTime endDate)
        {
            var incomeItems = _repository.Get(filter: i => beginDate <= i.Date && i.Date <= endDate);

            return _mapper.Map<IEnumerable<IncomeDto>>(incomeItems);
        }
    }
}
