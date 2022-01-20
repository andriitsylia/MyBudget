﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("{id}", Name = "IncomeGetById")]
        public ActionResult<IncomeReadDto> IncomeGetById(int id)
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
            var incomeItem = _mapper.Map<Income>(incomeCreateDto);
            
            _repository.Create(incomeItem);
            _repository.SaveChanges();

            var incomeReadDto = _mapper.Map<IncomeReadDto>(incomeItem);

            return CreatedAtRoute(nameof(IncomeGetById), new { id = incomeReadDto.Id}, incomeReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, IncomeUpdateDto incomeUpdateDto)
        {
            var incomeItem = _repository.GetById(id);
            
            if (incomeItem == null)
            {
                return NotFound();
            }

            _mapper.Map(incomeUpdateDto, incomeItem);
            _repository.Update(incomeItem);
            _repository.SaveChanges();

            return Ok();
        }
    }
}
