using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using BLL.Interfaces;
using DTO.IncomeType;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeTypeController : ControllerBase
    {
        private readonly IBudgetService<IncomeTypeDto> _service;
        private readonly IMapper _mapper;

        public IncomeTypeController(IBudgetService<IncomeTypeDto> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<IncomeTypeReadDto>> GetAll()
        {
            var incomeTypeDtoItems = _service.GetAll();

            if (incomeTypeDtoItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<IncomeTypeReadDto>>(incomeTypeDtoItems));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}", Name = "IncomeTypeGetById")]
        public ActionResult<IncomeTypeReadDto> IncomeTypeGetById(int id)
        {
            var incomeTypeDtoItem = _service.GetById(id);
            
            if (incomeTypeDtoItem != null)
            {
                return Ok(_mapper.Map<IncomeTypeReadDto>(incomeTypeDtoItem));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<IncomeTypeReadDto> Create(IncomeTypeCreateDto incomeTypeCreateDto)
        {
            var incomeTypeDtoItem = _mapper.Map<IncomeTypeDto>(incomeTypeCreateDto);

            _service.Create(incomeTypeDtoItem);

            var incomeTypeReadDto = _mapper.Map<IncomeTypeReadDto>(incomeTypeDtoItem);

            return CreatedAtRoute(nameof(IncomeTypeGetById), new { id = incomeTypeReadDto.Id }, incomeTypeReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, IncomeTypeUpdateDto incomeTypeUpdateDto)
        {
            var incomeTypeDtoItem = _mapper.Map<IncomeTypeDto>(incomeTypeUpdateDto);

            if (_service.Update(/*id, */incomeTypeDtoItem))
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (_service.Delete(id))
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
