using System;
using DAL.Entities;

namespace MyBudget.Dtos
{
    public class IncomeCreateDto
    {
        public DateTime Date { get; set; }

        public float Sum { get; set; }

        public string Comment { get; set; }

        public int IncomeTypeId { get; set; }

    }
}
