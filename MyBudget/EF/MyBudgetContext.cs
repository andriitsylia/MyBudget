using Microsoft.EntityFrameworkCore;
using MyBudget.Models;

namespace MyBudget.EF
{
    public class MyBudgetContext : DbContext
    {
        public MyBudgetContext(DbContextOptions<MyBudgetContext> options) : base(options)
        {

        }
        public DbSet<IncomeType> IncomeTypes { get; set }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Expense> Expenses { get; set; }

    }
}
