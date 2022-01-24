using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class ExpenseDateTotalDto
    {
        public DateTime Date { get; set; }
        public float Total { get; set; }
        public IEnumerable<ExpenseDto> Expenses { get; set; }
    }
}
