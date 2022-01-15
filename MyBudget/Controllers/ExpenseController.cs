using MyBudget.Mocks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MyBudget.Models;
using MyBudget.Interfaces;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseRepository _repository;

        public ExpenseController(IExpenseRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Expense>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Expense> GetById(int id)
        {
            return Ok(_repository.GetById(id));
        }
    }
}
