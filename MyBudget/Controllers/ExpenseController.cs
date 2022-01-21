using MyBudget.Mocks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyBudget.Models;
using MyBudget.Interfaces;
using AutoMapper;
using MyBudget.Dtos;
using System;
using System.Linq;
using MyBudget.Services;

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

        [HttpGet("{id}", Name = "ExpenseGetById")]
        public ActionResult<ExpenseReadDto> ExpenseGetById(int id)
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

        [HttpGet("date={date}")]
        public ActionResult<IEnumerable<ExpenseReportDto>> GetByDate(string date)
        {
            if (date == null)
            {
                return BadRequest();
            }

            if (!DateTime.TryParse(date, out DateTime beginDate))
            {
                return BadRequest();
            }

            var expenseItems = _repository.GetByDate(beginDate, beginDate);

            if (expenseItems != null && expenseItems.Any())
            {
                return Ok(new TotalExpense().GetbyDateInterval(beginDate, beginDate, expenseItems));
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("begindate={begindate}&enddate={enddate}")]
        public ActionResult<IEnumerable<ExpenseReadDto>> GetByDate(string begindate, string enddate)
        {
            if (begindate == null || enddate == null)
            {
                return BadRequest();
            }

            if (!(DateTime.TryParse(begindate, out DateTime beginDate) && DateTime.TryParse(enddate, out DateTime endDate)))
            {
                return BadRequest();
            }

            var expenseItems = _repository.GetByDate(beginDate, endDate);

            if (expenseItems != null && expenseItems.Any())
            {
                return Ok(new TotalExpense().GetbyDateInterval(beginDate, endDate, expenseItems));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<ExpenseReadDto> Create(ExpenseCreateDto expenseCreateDto)
        {
            var expense = _mapper.Map<Expense>(expenseCreateDto);
            _repository.Create(expense);
            _repository.SaveChanges();

            var expenseReadDto = _mapper.Map<ExpenseReadDto>(expense);

            return CreatedAtRoute(nameof(ExpenseGetById), new { id = expenseReadDto.Id}, expenseReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, ExpenseUpdateDto expenseUpdateDto)
        {
            var expenseItem = _repository.GetById(id);
            
            if (expenseItem == null)
            {
                return NotFound();
            }

            _mapper.Map(expenseUpdateDto, expenseItem);
            _repository.Update(expenseItem);
            _repository.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var expenseItem = _repository.GetById(id);
            if (expenseItem == null)
            {
                return NotFound();
            }

            _repository.Delete(expenseItem);
            _repository.SaveChanges();

            return Ok();
        }
    }
}
