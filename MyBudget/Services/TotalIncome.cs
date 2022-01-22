using MyBudget.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entities;

namespace MyBudget.Services
{
    public class TotalIncome
    {
        public IncomeReportDto GetbyDateInterval(DateTime beginDate, DateTime endDate, IEnumerable<Income> incomes)
        {
            return new IncomeReportDto()
            {
                BeginDate = beginDate,
                EndDate = endDate,
                Total = incomes.Select(i => i.Sum).Sum(),
                Incomes = incomes
            };
        }

    }
}