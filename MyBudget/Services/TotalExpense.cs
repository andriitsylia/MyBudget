using MyBudget.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entities;

namespace MyBudget.Services
{
    public class TotalExpense
    {
        public ExpenseReportDto GetbyDateInterval(DateTime beginDate, DateTime endDate, IEnumerable<Expense> expense)
        {
            return new ExpenseReportDto()
            {
                BeginDate = beginDate,
                EndDate = endDate,
                Total = expense.Select(i => i.Sum).Sum(),
                Expenses = expense
            };
        }


    }
}
