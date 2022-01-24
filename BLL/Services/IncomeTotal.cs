using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Dtos;

namespace BLL.Services
{
    public class IncomeTotal
    {
        public IncomeDateTotalDto GetbyDate(DateTime date, IEnumerable<IncomeDto> incomes)
        {
            if (incomes == null)
            {
                throw new ArgumentNullException(nameof(incomes));
            }

            var incomeDateTotal = new IncomeDateTotalDto()
            {
                Date = date,
                Total = incomes.Select(i => i.Sum).Sum(),
                Incomes = incomes
            };

            return incomeDateTotal;
        }

        public IncomeDateIntervalTotalDto GetbyDateInterval(DateTime beginDate, DateTime endDate, IEnumerable<IncomeDto> incomes)
        {
            if (incomes == null)
            {
                throw new ArgumentNullException(nameof(incomes));
            }

            var incomeDateIntervalTotal = new IncomeDateIntervalTotalDto()
            {
                BeginDate = beginDate,
                EndDate = endDate,
                Total = incomes.Select(i => i.Sum).Sum(),
                Incomes = incomes
            };

            return incomeDateIntervalTotal;
        }
    }
}