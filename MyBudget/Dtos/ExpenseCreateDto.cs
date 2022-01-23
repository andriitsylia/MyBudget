using System;

namespace MyBudget.Dtos
{
    public class ExpenseCreateDto
    {
        public DateTime Date { get; set; }
        public float Sum { get; set; }
        public string Comment { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
