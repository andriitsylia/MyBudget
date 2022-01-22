using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using MyBudget.Dtos;
using DAL.Entities;
using DAL.Interfaces;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeTypeController : ControllerBase
    {
        private readonly IIncomeTypeRepository _repository;
        private readonly IMapper _mapper;

        public IncomeTypeController(IIncomeTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<IncomeTypeReadDto>> GetAll()
        {
            var incomeTypeItems = _repository.GetAll();
            
            if (incomeTypeItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<IncomeTypeReadDto>>(incomeTypeItems));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}", Name = "IncomeTypeGetById")]
        public ActionResult<IncomeTypeReadDto> IncomeTypeGetById(int id)
        {
            var incomeTypeItem = _repository.GetById(id);
            
            if (incomeTypeItem != null)
            {
                return Ok(_mapper.Map<IncomeTypeReadDto>(incomeTypeItem));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<IncomeTypeReadDto> Create(IncomeTypeCreateDto incomeTypeCreateDto)
        {
            var incomeTypeItem = _mapper.Map<IncomeType>(incomeTypeCreateDto);

            _repository.Create(incomeTypeItem);
            _repository.SaveChanges();

            var incomeTypeReadDto = _mapper.Map<IncomeTypeReadDto>(incomeTypeItem);

            return CreatedAtRoute(nameof(IncomeTypeGetById), new { id = incomeTypeReadDto.Id }, incomeTypeReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, IncomeTypeUpdateDto incomeTypeUpdateDto)
        {
            var incomeTypeItem = _repository.GetById(id);
            
            if (incomeTypeItem == null)
            {
                return NotFound();
            }

            _mapper.Map(incomeTypeUpdateDto, incomeTypeItem);
            _repository.Update(incomeTypeItem);
            _repository.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var incomeTypeItem = _repository.GetById(id);
            if (incomeTypeItem == null)
            {
                return NotFound();
            }
            _repository.Delete(incomeTypeItem);
            _repository.SaveChanges();

            return Ok();
        }
    }
}
