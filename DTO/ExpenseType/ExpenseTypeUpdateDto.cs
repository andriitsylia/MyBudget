using System.ComponentModel.DataAnnotations;

namespace DTO.ExpenseType
{
    public class ExpenseTypeUpdateDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Comment { get; set; }
    }
}
