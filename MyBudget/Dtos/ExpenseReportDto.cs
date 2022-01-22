using System;
using System.Collections.Generic;
using DAL.Entities;

namespace MyBudget.Dtos
{
    public class ExpenseReportDto
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Total { get; set; }
        public IEnumerable<Expense> Expenses { get; set; }

    }
}
