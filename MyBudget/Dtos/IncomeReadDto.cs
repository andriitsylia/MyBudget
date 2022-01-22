using System;
using DAL.Entities;

namespace MyBudget.Dtos
{
    public class IncomeReadDto
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public float Sum { get; set; }

        public string Comment { get; set; }

        public IncomeType IncomeType { get; set; }

    }
}
