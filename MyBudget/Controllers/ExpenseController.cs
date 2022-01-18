using MyBudget.Mocks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyBudget.Models;
using MyBudget.Interfaces;
using AutoMapper;
using MyBudget.Dtos;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseRepository _repository;
        private readonly IMapper _mapper;

        public ExpenseController(IExpenseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ExpenseReadDto>> GetAll()
        {
            var expenseItems= _repository.GetAll();
            if (expenseItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<ExpenseReadDto>>(expenseItems));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ExpenseReadDto> GetById(int id)
        {
            var expenseItem = _repository.GetById(id);
            if (expenseItem != null)
            {
                return Ok(_mapper.Map<ExpenseReadDto>(expenseItem));
            }
            else
            {
                return NotFound();
            }
        }
    }
}
