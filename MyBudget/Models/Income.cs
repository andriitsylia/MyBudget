using System;
using System.ComponentModel.DataAnnotations;

namespace MyBudget.Models
{
    public class Income
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
        public int IncomeTypeId { get; set; }

        public IncomeType IncomeType { get; set; }


    }
}
