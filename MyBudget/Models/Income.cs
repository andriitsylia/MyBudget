using System;

namespace MyBudget.Models
{
    public class Income
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public IncomeType IncomeType { get; set; }
        public float Sum { get; set; }
        public string Comment { get; set; }
    }
}
