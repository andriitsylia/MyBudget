using System;
using System.ComponentModel.DataAnnotations;

namespace MyBudget.Dtos
{
    public class ExpenseUpdateDto
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public float Sum { get; set; }

        [MaxLength(50)]
        public string Comment { get; set; }

        [Required]
        public int ExpenseTypeId { get; set; }
    }
}
