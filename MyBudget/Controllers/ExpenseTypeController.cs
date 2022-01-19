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

        [HttpGet("{id}")]
        public ActionResult<ExpenseTypeReadDto> GetById(int id)
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
            var expenseType = _mapper.Map<ExpenseType>(expenseTypeCreateDto);
            _repository.Create(expenseType);
            _repository.SaveChanges();

            return Ok(expenseType);
        }

    }
}
