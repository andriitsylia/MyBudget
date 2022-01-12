using System;

namespace MyBudget.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public float Sum { get; set; }
        public string Comment { get; set; }
    }
}
