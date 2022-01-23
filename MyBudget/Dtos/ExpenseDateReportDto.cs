using System;
using System.Collections.Generic;

namespace MyBudget.Dtos
{
    public class ExpenseDateReportDto
    {
        public DateTime Date { get; set; }
        public float Total { get; set; }
        public IEnumerable<ExpenseReadDto> Expenses { get; set; }
    }
}
