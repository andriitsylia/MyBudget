using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Entities;

namespace DAL.Configurations
{
    public class ExpenseTypeConfiguration : IEntityTypeConfiguration<ExpenseType>
    {
        public void Configure(EntityTypeBuilder<ExpenseType> builder)
        {
            builder.HasData(new ExpenseType() { Id = 1, Name = "Food", Comment = "Butter, bread, milk, etc." },
                            new ExpenseType() { Id = 2, Name = "Clothes", Comment = "Jacket, T-shirt, socks etc." },
                            new ExpenseType() { Id = 3, Name = "Connection", Comment = "Internet, mobile phone, etc." },
                            new ExpenseType() { Id = 4, Name = "Education", Comment = "Course, etc." },
                            new ExpenseType() { Id = 5, Name = "Health", Comment = "" },
                            new ExpenseType() { Id = 6, Name = "Utillities", Comment = "" },
                            new ExpenseType() { Id = 7, Name = "Transport", Comment = "Ticket, etc." },
                            new ExpenseType() { Id = 8, Name = "Services", Comment = "" },
                            new ExpenseType() { Id = 9, Name = "Gifts", Comment = "" },
                            new ExpenseType() { Id = 10, Name = "Entertainment", Comment = "Movie, theater, zoo, etc." },
                            new ExpenseType() { Id = 11, Name = "Car", Comment = "Repair, fuel, etc." },
                            new ExpenseType() { Id = 12, Name = "Ensurance", Comment = "Health, life, car, house, etc." },
                            new ExpenseType() { Id = 13, Name = "Vacation", Comment = "Germany, USA, Turkey, Egypt, etc." });
        }
    }
}
