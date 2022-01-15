using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyBudget.Mocks;
using MyBudget.Models;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseTypeController : ControllerBase
    {
        private readonly MockExpenseTypeRepository _repository = new();

        [HttpGet]
        public ActionResult<IEnumerable<ExpenseType>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<ExpenseType> GetById(int id)
        {
            return Ok(_repository.GetById(id));
        }

    }
}
