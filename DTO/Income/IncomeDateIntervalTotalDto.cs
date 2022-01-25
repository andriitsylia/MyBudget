using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Income
{
    public class IncomeDateIntervalTotalDto
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Total { get; set; }
        public IEnumerable<IncomeDto> Incomes { get; set; }
    }
}
