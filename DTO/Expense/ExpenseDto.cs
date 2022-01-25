using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Expense
{
    public class ExpenseDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Sum { get; set; }
        public string Comment { get; set; }
        public int ExpenseTypeId { get; set; }
    }
}
