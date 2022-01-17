using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBudget.Models;

namespace MyBudget.Configurations
{
    public class IncomeTypeConfiguration : IEntityTypeConfiguration<IncomeType>
    {
        public void Configure(EntityTypeBuilder<IncomeType> builder)
        {
            builder.HasData(new IncomeType() { Id = 1, Name = "Salary", Comment = "Main money" },
                            new IncomeType() { Id = 2, Name = "Part-time job", Comment = "Additional money" },
                            new IncomeType() { Id = 3, Name = "Royalty", Comment = "Excellent money" },
                            new IncomeType() { Id = 4, Name = "Gift", Comment = "Nice money" });
        }
    }
}
