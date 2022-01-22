using Microsoft.EntityFrameworkCore;
using DAL.Entities;
using DAL.Configurations;

namespace DAL.EF
{
    public class MyBudgetContext : DbContext
    {
        public DbSet<IncomeType> IncomeTypes { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        
        public MyBudgetContext(DbContextOptions<MyBudgetContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IncomeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new IncomeConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenseTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
        }
    }
}
