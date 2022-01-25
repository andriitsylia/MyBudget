using System.ComponentModel.DataAnnotations;

namespace DTO.IncomeType
{
    public class IncomeTypeCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string Comment { get; set; }

    }
}
