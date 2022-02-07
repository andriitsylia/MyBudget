using DTO.IncomeType;
using System;

namespace DTO.Income
{
    public class IncomeReadDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Sum { get; set; }
        public string Comment { get; set; }
        public int IncomeTypeId { get; set; }
        public IncomeTypeReadDto IncomeType { get; set; }
    }
}
