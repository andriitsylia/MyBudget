using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BLL.Interfaces;
using DTO.ExpenseType;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseTypeController : ControllerBase
    {
        private readonly IBudgetService<ExpenseTypeDto> _service;
        private readonly IMapper _mapper;

        public ExpenseTypeController(IBudgetService<ExpenseTypeDto> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ExpenseTypeReadDto>> GetAll()
        {
            var expenseTypeDtoItems = _service.GetAll();

            if (expenseTypeDtoItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<ExpenseTypeReadDto>>(expenseTypeDtoItems));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}", Name ="ExpenseTypeGetById")]
        public ActionResult<ExpenseTypeReadDto> ExpenseTypeGetById(int id)
        {
            var expenseTypeDtoItem = _service.GetById(id);
            
            if (expenseTypeDtoItem != null)
            {
                return Ok(_mapper.Map<ExpenseTypeReadDto>(expenseTypeDtoItem));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<ExpenseTypeReadDto> Create(ExpenseTypeCreateDto expenseTypeCreateDto)
        {
            var expenseTypeDtoItem = _mapper.Map<ExpenseTypeDto>(expenseTypeCreateDto);

            _service.Create(expenseTypeDtoItem);

            var expenseTypeReadDto = _mapper.Map<ExpenseTypeReadDto>(expenseTypeDtoItem);

            return CreatedAtRoute(nameof(ExpenseTypeGetById), new { id = expenseTypeReadDto.Id }, expenseTypeReadDto);
        }

        [HttpPut/*("{id}")*/]
        public ActionResult Update(/*int id, */ExpenseTypeUpdateDto expenseTypeUpdateDto)
        {
            var expenseTypeDtoItem = _mapper.Map<ExpenseTypeDto>(expenseTypeUpdateDto);

            if (_service.Update(/*id, */expenseTypeDtoItem))
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
