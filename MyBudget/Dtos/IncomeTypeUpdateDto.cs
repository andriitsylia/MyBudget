using System.ComponentModel.DataAnnotations;

namespace MyBudget.Dtos
{
    public class IncomeTypeUpdateDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Comment { get; set; }

    }
}
