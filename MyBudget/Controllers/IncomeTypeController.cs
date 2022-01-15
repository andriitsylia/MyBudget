using Microsoft.AspNetCore.Mvc;
using MyBudget.Mocks;
using MyBudget.Models;
using System.Collections.Generic;

namespace MyBudget.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeTypeController : ControllerBase
    {
        private readonly MockIncomeTypeRepository _repository = new();

        [HttpGet]
        public ActionResult<IEnumerable<IncomeType>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<IncomeType> GetById(int id)
        {
            return Ok(_repository.GetById(id));
        }
    }
}
