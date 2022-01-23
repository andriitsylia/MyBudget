using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class IncomeType
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Comment { get; set; }

        public ICollection<Income> Incomes { get; set; }
    }
}
