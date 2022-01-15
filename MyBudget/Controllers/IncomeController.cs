using Microsoft.AspNetCore.Mvc;
using MyBudget.Mocks;
using System.Collections.Generic;
using MyBudget.Models;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeController : ControllerBase
    {
        private readonly MockIncomeRepository _repository = new();

        [HttpGet]
        public ActionResult<IEnumerable<Income>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Income> GetById(int id)
        {
            return Ok(_repository.GetById(id));
        }
    }
}
