using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyBudget.Mocks;
using MyBudget.Models;
using MyBudget.Interfaces;
using AutoMapper;
using MyBudget.Dtos;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseTypeController : ControllerBase
    {
        private readonly IExpenseTypeRepository _repository;
        private readonly IMapper _mapper;

        public ExpenseTypeController(IExpenseTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ExpenseTypeReadDto>> GetAll()
        {
            var expenseTypeItems = _repository.GetAll();
            
            if (expenseTypeItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<ExpenseTypeReadDto>>(expenseTypeItems));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}", Name ="ExpenseTypeGetById")]
        public ActionResult<ExpenseTypeReadDto> ExpenseTypeGetById(int id)
        {
            var expenseTypeItem = _repository.GetById(id);
            
            if (expenseTypeItem != null)
            {
                return Ok(_mapper.Map<ExpenseTypeReadDto>(expenseTypeItem));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<ExpenseTypeReadDto> Create(ExpenseTypeCreateDto expenseTypeCreateDto)
        {
            var expenseTypeItem = _mapper.Map<ExpenseType>(expenseTypeCreateDto);
            _repository.Create(expenseTypeItem);
            _repository.SaveChanges();

            var expenseTypeReadDto = _mapper.Map<ExpenseTypeReadDto>(expenseTypeItem);

            return CreatedAtRoute(nameof(ExpenseTypeGetById), new { id = expenseTypeReadDto.Id}, expenseTypeReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, ExpenseTypeUpdateDto expenseTypeUpdateDto)
        {
            var expenseTypeItem = _repository.GetById(id);
            
            if (expenseTypeItem == null)
            {
                return NotFound();
            }

            _mapper.Map(expenseTypeUpdateDto, expenseTypeItem);
            _repository.Update(expenseTypeItem);
            _repository.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var expenseTypeItem = _repository.GetById(id);
            if (expenseTypeItem == null)
            {
                return NotFound();
            }

            _repository.Delete(expenseTypeItem);
            _repository.SaveChanges();

            return Ok();
        }

    }
}
