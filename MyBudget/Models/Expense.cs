using System;
using System.ComponentModel.DataAnnotations;

namespace MyBudget.Models
{
    public class Expense
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public float Sum { get; set; }

        [MaxLength(50)]
        public string Comment { get; set; }

        [Required]
        public int ExpenseTypeId { get; set; }

        public ExpenseType ExpenseType { get; set; }
    }
}
