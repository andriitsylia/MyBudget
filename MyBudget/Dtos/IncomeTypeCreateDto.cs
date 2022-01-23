using System.ComponentModel.DataAnnotations;

namespace MyBudget.Dtos
{
    public class IncomeTypeCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string Comment { get; set; }

    }
}
