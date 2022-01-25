using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Expense
{
    public class ExpenseDateIntervalTotalDto
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Total { get; set; }
        public IEnumerable<ExpenseDto> Expenses { get; set; }
    }
}
