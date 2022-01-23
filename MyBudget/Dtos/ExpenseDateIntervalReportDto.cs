using System;
using System.Collections.Generic;

namespace MyBudget.Dtos
{
    public class ExpenseDateIntervalReportDto
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Total { get; set; }
        public IEnumerable<ExpenseReadDto> Expenses { get; set; }
    }
}
