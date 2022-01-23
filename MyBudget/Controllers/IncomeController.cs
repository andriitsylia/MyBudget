using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using BLL.Dtos;
using System;
using BLL.Services;
using System.Linq;
using DAL.Entities;
using DAL.Interfaces;
using BLL.Interfaces;
using MyBudget.Dtos;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeController : ControllerBase
    {
        private readonly IDateService<IncomeDto> _service;
        private readonly IMapper _mapper;

        public IncomeController(IDateService<IncomeDto> service, IMapper mapper)
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

            if (incomeDtoItems != null && incomeDtoItems.Any())
            {
                var incomeDateReportDto = new IncomeDateReportDto();

                incomeDateReportDto.Date = reportDate;
                incomeDateReportDto.Total = incomeDtoItems.Select(i => i.Sum).Sum();
                incomeDateReportDto.Incomes = _mapper.Map<IEnumerable<IncomeReadDto>>(incomeDtoItems);

                return Ok(incomeDateReportDto);
            }
            else
            {
                return NotFound();
            }
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

            if (incomeDtoItems != null && incomeDtoItems.Any())
            {
                var incomeDateIntervalReportDto = new IncomeDateIntervalReportDto();

                incomeDateIntervalReportDto.BeginDate = beginDate;
                incomeDateIntervalReportDto.EndDate = endDate;
                incomeDateIntervalReportDto.Total = incomeDtoItems.Select(i => i.Sum).Sum();
                incomeDateIntervalReportDto.Incomes = _mapper.Map<IEnumerable<IncomeReadDto>>(incomeDtoItems);

                return Ok(incomeDateIntervalReportDto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<IncomeReadDto> Create(IncomeCreateDto incomeCreateDto)
        {
            var incomeDtoItem = _mapper.Map<IncomeDto>(incomeCreateDto);

            _service.Create(incomeDtoItem);

            var incomeReadDto = _mapper.Map<IncomeReadDto>(incomeDtoItem);

            return CreatedAtRoute(nameof(IncomeGetById), new { id = incomeReadDto.Id }, incomeReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, IncomeUpdateDto incomeUpdateDto)
        {
            var incomeDtoItem = _mapper.Map<IncomeDto>(incomeUpdateDto);

            if (_service.Update(id, incomeDtoItem))
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
