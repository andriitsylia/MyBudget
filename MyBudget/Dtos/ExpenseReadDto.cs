using System;
using DAL.Entities;

namespace MyBudget.Dtos
{
    public class ExpenseReadDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Sum { get; set; }
        public string Comment { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
