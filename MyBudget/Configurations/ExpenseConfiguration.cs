using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBudget.Models;
using System;

namespace MyBudget.Configurations
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasData(new Expense() { Id = 1, Date = new DateTime(2021, 01, 15), Sum = 10, Comment = "Bread", ExpenseTypeId = 1 },
                new Expense() { Id = 2, Date = new DateTime(2021, 02, 15), Sum = 20, Comment = "Socks", ExpenseTypeId = 2 },
                new Expense() { Id = 3, Date = new DateTime(2021, 03, 15), Sum = 30, Comment = "Internet", ExpenseTypeId = 3 },
                new Expense() { Id = 4, Date = new DateTime(2021, 04, 15), Sum = 40, Comment = "Course", ExpenseTypeId = 4 },
                new Expense() { Id = 5, Date = new DateTime(2021, 05, 15), Sum = 50, Comment = "", ExpenseTypeId = 5 },
                new Expense() { Id = 6, Date = new DateTime(2021, 06, 15), Sum = 60, Comment = "", ExpenseTypeId = 6 },
                new Expense() { Id = 7, Date = new DateTime(2021, 07, 15), Sum = 70, Comment = "Bus", ExpenseTypeId = 7 },
                new Expense() { Id = 8, Date = new DateTime(2021, 08, 15), Sum = 80, Comment = "", ExpenseTypeId = 8 },
                new Expense() { Id = 9, Date = new DateTime(2021, 09, 15), Sum = 90, Comment = "Wife", ExpenseTypeId = 9 },
                new Expense() { Id = 10, Date = new DateTime(2021, 10, 15), Sum = 100, Comment = "Theater", ExpenseTypeId = 10 },
                new Expense() { Id = 11, Date = new DateTime(2021, 11, 15), Sum = 110, Comment = "Fuel", ExpenseTypeId = 11 },
                new Expense() { Id = 12, Date = new DateTime(2021, 12, 15), Sum = 120, Comment = "Life", ExpenseTypeId = 12 },
                new Expense() { Id = 13, Date = new DateTime(2021, 12, 31), Sum = 130, Comment = "USA", ExpenseTypeId = 13 });
        }
    }
}