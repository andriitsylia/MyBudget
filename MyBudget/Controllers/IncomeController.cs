using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using System;
using System.Linq;
using BLL.Interfaces;
using BLL.Services;
using DTO.Income;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeController : ControllerBase
    {
        private readonly IByDateService<IncomeDto> _service;
        private readonly IMapper _mapper;

        public IncomeController(IByDateService<IncomeDto> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<IncomeReadDto>> GetAll()
        {
            var incomeDtoItems = _service.GetAll();

            if (incomeDtoItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<IncomeReadDto>>(incomeDtoItems));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}", Name = "IncomeGetById")]
        public ActionResult<IncomeReadDto> IncomeGetById(int id)
        {
            var incomeDtoItem = _service.GetById(id);

            if (incomeDtoItem != null)
            {
                return Ok(_mapper.Map<IncomeReadDto>(incomeDtoItem));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("date={date}")]
        public ActionResult<IEnumerable<IncomeDateReportDto>> GetByDate(string date)
        {
            if (date == null)
            {
                return BadRequest();
            }

            if (!DateTime.TryParse(date, out DateTime reportDate))
            {
                return BadRequest();
            }
            var incomeDtoItems = _service.GetByDate(reportDate);

            if (incomeDtoItems == null || !(incomeDtoItems.Any()))
            {
                return NotFound();
            }

            var incomeDateTotal = new IncomeTotal().GetbyDate(reportDate, incomeDtoItems);

            return Ok(_mapper.Map<IncomeDateReportDto>(incomeDateTotal));
        }

        [HttpGet("begindate={begindate}&enddate={enddate}")]
        public ActionResult<IEnumerable<IncomeDateReportDto>> GetByDate(string begindate, string enddate)
        {
            if (begindate == null || enddate == null)
            {
                return BadRequest();
            }

            if (!(DateTime.TryParse(begindate, out DateTime beginDate) && DateTime.TryParse(enddate, out DateTime endDate)))
            {
                return BadRequest();
            }

            var incomeDtoItems = _service.GetByDateInterval(beginDate, endDate);

            if (incomeDtoItems == null || !(incomeDtoItems.Any()))
            {
                return NotFound();
            }

            var incomeDateIntervalTotal = new IncomeTotal().GetbyDateInterval(beginDate, endDate, incomeDtoItems);

            return Ok(_mapper.Map<IncomeDateIntervalReportDto>(incomeDateIntervalTotal));
        }

        [HttpPost]
        public ActionResult<IncomeReadDto> Create(IncomeCreateDto incomeCreateDto)
        {
            var incomeDtoItem = _mapper.Map<IncomeDto>(incomeCreateDto);

            _service.Create(incomeDtoItem);

            var incomeReadDto = _mapper.Map<IncomeReadDto>(incomeDtoItem);

            return CreatedAtRoute(nameof(IncomeGetById), new { id = incomeReadDto.Id }, incomeReadDto);
        }

        [HttpPut/*("{id}")*/]
        public ActionResult Update(/*int id, */IncomeUpdateDto incomeUpdateDto)
        {
            var incomeDtoItem = _mapper.Map<IncomeDto>(incomeUpdateDto);

            if (_service.Update(/*id, */incomeDtoItem))
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
