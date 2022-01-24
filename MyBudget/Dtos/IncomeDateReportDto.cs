using System;
using System.Collections.Generic;

namespace MyBudget.Dtos
{
    public class IncomeDateReportDto
    {
        public DateTime Date { get; set; }
        public float Total { get; set; }
        public IEnumerable<IncomeReadDto> Incomes { get; set; }
    }
}
