using System;
using System.Collections.Generic;

namespace DTO.Income
{
    public class IncomeDateIntervalReportDto
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Total { get; set; }
        public IEnumerable<IncomeReadDto> Incomes { get; set; }
    }
}
