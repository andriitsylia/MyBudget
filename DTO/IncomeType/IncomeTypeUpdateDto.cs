using System.ComponentModel.DataAnnotations;

namespace DTO.IncomeType
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
