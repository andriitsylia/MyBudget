using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class IncomeTypeService : IBudgetService<IncomeTypeDto>
    {
        private readonly IBudgetRepository<IncomeType> _repository;
        private readonly IMapper _mapper;

        public IncomeTypeService(IBudgetRepository<IncomeType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(IncomeTypeDto item)
        {
            var incomeTypeItem = _mapper.Map<IncomeType>(item);

            _repository.Create(incomeTypeItem);
            _repository.SaveChanges();
        }

        public IEnumerable<IncomeTypeDto> GetAll()
        {
            var incomeTypeItems = _repository.Get();

            return _mapper.Map <IEnumerable<IncomeTypeDto>>(incomeTypeItems);
        }

        public IncomeTypeDto GetById(int id)
        {
            var incomeTypeItem = _repository.GetById(id);

            return _mapper.Map<IncomeTypeDto>(incomeTypeItem);
        }

        public bool Update(int id, IncomeTypeDto item)
        {
            var incomeTypeItem = _repository.GetById(id);

            if (incomeTypeItem == null)
            {
                return false;
            }

            _mapper.Map(item, incomeTypeItem);
            _repository.Update(incomeTypeItem);
            _repository.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var incomeTypeItem = _repository.GetById(id);

            if (incomeTypeItem == null)
            {
                return false;
            }

            _repository.Delete(incomeTypeItem);
            _repository.SaveChanges();
            
            return true;
        }
    }
}
