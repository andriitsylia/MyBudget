using Microsoft.AspNetCore.Mvc;
using MyBudget.Mocks;
using System.Collections.Generic;
using MyBudget.Models;
using MyBudget.Interfaces;
using AutoMapper;
using MyBudget.Dtos;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeRepository _repository;
        private readonly IMapper _mapper;

        public IncomeController(IIncomeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<IncomeReadDto>> GetAll()
        {
            var incomeItems = _repository.GetAll();
            if (incomeItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<IncomeReadDto>>(incomeItems));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<IncomeReadDto> GetById(int id)
        {
            var incomeItem = _repository.GetById(id);
            if (incomeItem != null)
            {
                return Ok(_mapper.Map<IncomeReadDto>(incomeItem));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<IncomeReadDto> Create(IncomeCreateDto incomeCreateDto)
        {
            var income = _mapper.Map<Income>(incomeCreateDto);
            _repository.Create(income);
            _repository.SaveChanges();

            return Ok(income);
        }
    }
}
