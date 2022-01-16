
using System.ComponentModel.DataAnnotations;

namespace MyBudget.Models
{
    public class ExpenseType
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Comment { get; set; }
    }
}
