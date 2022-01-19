﻿using Microsoft.AspNetCore.Mvc;
using MyBudget.Mocks;
using MyBudget.Models;
using System.Collections.Generic;
using MyBudget.Interfaces;
using AutoMapper;
using MyBudget.Dtos;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeTypeController : ControllerBase
    {
        private readonly IIncomeTypeRepository _repository;
        private readonly IMapper _mapper;

        public IncomeTypeController(IIncomeTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<IncomeTypeReadDto>> GetAll()
        {
            var incomeTypeItems = _repository.GetAll();
            if (incomeTypeItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<IncomeTypeReadDto>>(incomeTypeItems));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}", Name ="IncomeTypeGetById")]
        public ActionResult<IncomeTypeReadDto> IncomeTypeGetById(int id)
        {
            var incomeTypeItem = _repository.GetById(id);
            if (incomeTypeItem != null)
            {
                return Ok(_mapper.Map<IncomeTypeReadDto>(incomeTypeItem));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<IncomeTypeReadDto> Create(IncomeTypeCreateDto incomeTypeCreateDto)
        {
            var incomeType = _mapper.Map<IncomeType>(incomeTypeCreateDto);
            
            _repository.Create(incomeType);
            _repository.SaveChanges();

            var incomeTypeReadDto = _mapper.Map<IncomeTypeReadDto>(incomeType);

            return CreatedAtRoute(nameof(IncomeTypeGetById), new { id = incomeTypeReadDto.Id}, incomeTypeReadDto);
        }
    }
}
