using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using DAL.Entities;

namespace DAL.Configurations
{
    public class IncomeConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.HasData(new Income() { Id = 1, Date = new DateTime(2021, 01, 01), Sum = 1000, Comment = "Good job", IncomeTypeId = 1 },
                            new Income() { Id = 2, Date = new DateTime(2021, 02, 01), Sum = 100, Comment = "", IncomeTypeId = 2 },
                            new Income() { Id = 3, Date = new DateTime(2021, 03, 01), Sum = 1000, Comment = "Good job", IncomeTypeId = 1 },
                            new Income() { Id = 4, Date = new DateTime(2021, 04, 01), Sum = 10, Comment = "", IncomeTypeId = 3 },
                            new Income() { Id = 5, Date = new DateTime(2021, 05, 01), Sum = 1000, Comment = "Good job", IncomeTypeId = 1 },
                            new Income() { Id = 6, Date = new DateTime(2021, 06, 01), Sum = 1, Comment = "", IncomeTypeId = 4 },
                            new Income() { Id = 7, Date = new DateTime(2021, 07, 01), Sum = 1000, Comment = "Good job", IncomeTypeId = 1 },
                            new Income() { Id = 8, Date = new DateTime(2021, 08, 01), Sum = 100, Comment = "", IncomeTypeId = 2 },
                            new Income() { Id = 9, Date = new DateTime(2021, 09, 01), Sum = 1000, Comment = "Good job", IncomeTypeId = 1 },
                            new Income() { Id = 10, Date = new DateTime(2021, 10, 01), Sum = 10, Comment = "", IncomeTypeId = 3 },
                            new Income() { Id = 11, Date = new DateTime(2021, 11, 01), Sum = 1000, Comment = "Good job", IncomeTypeId = 1 },
                            new Income() { Id = 12, Date = new DateTime(2021, 12, 01), Sum = 1, Comment = "", IncomeTypeId = 4 });
        }
    }
}
