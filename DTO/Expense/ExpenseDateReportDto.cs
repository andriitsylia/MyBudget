using System;
using System.Collections.Generic;

namespace DTO.Expense
{
    public class ExpenseDateReportDto
    {
        public DateTime Date { get; set; }
        public float Total { get; set; }
        public IEnumerable<ExpenseReadDto> Expenses { get; set; }
    }
}
