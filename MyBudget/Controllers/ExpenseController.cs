using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using System;
using System.Linq;
using BLL.Interfaces;
using BLL.Services;
using DTO.Expense;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly IByDateService<ExpenseDto> _service;
        private readonly IMapper _mapper;

        public ExpenseController(IByDateService<ExpenseDto> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ExpenseReadDto>> GetAll()
        {
            var expenseDtoItems = _service.GetAll();

            if (expenseDtoItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<ExpenseReadDto>>(expenseDtoItems));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}", Name = "ExpenseGetById")]
        public ActionResult<ExpenseReadDto> ExpenseGetById(int id)
        {
            var expenseDtoItem = _service.GetById(id);

            if (expenseDtoItem != null)
            {
                return Ok(_mapper.Map<ExpenseReadDto>(expenseDtoItem));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("date={date}")]
        public ActionResult<IEnumerable<ExpenseDateReportDto>> GetByDate(string date)
        {
            if (date == null)
            {
                return BadRequest();
            }

            if (!DateTime.TryParse(date, out DateTime reportDate))
            {
                return BadRequest();
            }

            var expenseDtoItems = _service.GetByDate(reportDate);

            if (expenseDtoItems == null || !expenseDtoItems.Any())
            {
                return NotFound();
            }

            var expenseDateTotal = new ExpenseTotal().GetbyDate(reportDate, expenseDtoItems);

            return Ok(_mapper.Map<ExpenseDateReportDto>(expenseDateTotal));

        }

        [HttpGet("begindate={begindate}&enddate={enddate}")]
        public ActionResult<IEnumerable<ExpenseDateIntervalReportDto>> GetByDate(string begindate, string enddate)
        {
            if (begindate == null || enddate == null)
            {
                return BadRequest();
            }

            if (!(DateTime.TryParse(begindate, out DateTime beginDate) && DateTime.TryParse(enddate, out DateTime endDate)))
            {
                return BadRequest();
            }

            var expenseDtoItems = _service.GetByDateInterval(beginDate, endDate);

            if (expenseDtoItems == null || !expenseDtoItems.Any())
            {
                return NotFound();
            }

            var expenseDateIntervalTotal = new ExpenseTotal().GetbyDateInterval(beginDate, endDate, expenseDtoItems);

            return Ok(_mapper.Map<ExpenseDateIntervalReportDto>(expenseDateIntervalTotal));
        }

        [HttpPost]
        public ActionResult<ExpenseReadDto> Create(ExpenseCreateDto expenseCreateDto)
        {
            var expenseDtoItem = _mapper.Map<ExpenseDto>(expenseCreateDto);

            _service.Create(expenseDtoItem);

            var expenseReadDto = _mapper.Map<ExpenseReadDto>(expenseDtoItem);

            return CreatedAtRoute(nameof(ExpenseGetById), new { id = expenseReadDto.Id }, expenseReadDto);
        }

        [HttpPut/*("{id}")*/]
        public ActionResult Update(/*int id, */ExpenseUpdateDto expenseUpdateDto)
        {
            var expenseDtoItem = _mapper.Map<ExpenseDto>(expenseUpdateDto);

            if (_service.Update(/*id, */expenseDtoItem))
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
