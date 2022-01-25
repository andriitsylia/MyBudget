using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Income
{
    public class IncomeDateTotalDto
    {
        public DateTime Date { get; set; }
        public float Total { get; set; }
        public IEnumerable<IncomeDto> Incomes { get; set; }
    }
}
