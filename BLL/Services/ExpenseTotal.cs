using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Expense;

namespace BLL.Services
{
    public class ExpenseTotal
    {
        public ExpenseDateTotalDto GetbyDate(DateTime date, IEnumerable<ExpenseDto> expenses)
        {
            if (expenses == null)
            {
                throw new ArgumentNullException(nameof(expenses));
            }

            var expenseDateTotal = new ExpenseDateTotalDto()
            {
                Date = date,
                Total = expenses.Select(i => i.Sum).Sum(),
                Expenses = expenses
            };

            return expenseDateTotal;
        }

        public ExpenseDateIntervalTotalDto GetbyDateInterval(DateTime beginDate, DateTime endDate, IEnumerable<ExpenseDto> expenses)
        {
            if (expenses == null)
            {
                throw new ArgumentNullException(nameof(expenses));
            }

            var expenseDateIntervalTotal = new ExpenseDateIntervalTotalDto()
            {
                BeginDate = beginDate,
                EndDate = endDate,
                Total = expenses.Select(i => i.Sum).Sum(),
                Expenses = expenses
            };

            return expenseDateIntervalTotal;
        }
    }
}
