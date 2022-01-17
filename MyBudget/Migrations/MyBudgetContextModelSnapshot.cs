﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBudget.EF;

namespace MyBudget.Migrations
{
    [DbContext(typeof(MyBudgetContext))]
    partial class MyBudgetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyBudget.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExpenseTypeId")
                        .HasColumnType("int");

                    b.Property<float>("Sum")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseTypeId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Bread",
                            Date = new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 1,
                            Sum = 10f
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Socks",
                            Date = new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 2,
                            Sum = 20f
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Internet",
                            Date = new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 3,
                            Sum = 30f
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Course",
                            Date = new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 4,
                            Sum = 40f
                        },
                        new
                        {
                            Id = 5,
                            Comment = "",
                            Date = new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 5,
                            Sum = 50f
                        },
                        new
                        {
                            Id = 6,
                            Comment = "",
                            Date = new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 6,
                            Sum = 60f
                        },
                        new
                        {
                            Id = 7,
                            Comment = "Bus",
                            Date = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 7,
                            Sum = 70f
                        },
                        new
                        {
                            Id = 8,
                            Comment = "",
                            Date = new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 8,
                            Sum = 80f
                        },
                        new
                        {
                            Id = 9,
                            Comment = "Wife",
                            Date = new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 9,
                            Sum = 90f
                        },
                        new
                        {
                            Id = 10,
                            Comment = "Theater",
                            Date = new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 10,
                            Sum = 100f
                        },
                        new
                        {
                            Id = 11,
                            Comment = "Fuel",
                            Date = new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 11,
                            Sum = 110f
                        },
                        new
                        {
                            Id = 12,
                            Comment = "Life",
                            Date = new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 12,
                            Sum = 120f
                        },
                        new
                        {
                            Id = 13,
                            Comment = "USA",
                            Date = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExpenseTypeId = 13,
                            Sum = 130f
                        });
                });

            modelBuilder.Entity("MyBudget.Models.ExpenseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("ExpenseTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Butter, bread, milk, etc.",
                            Name = "Food"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Jacket, T-shirt, socks etc.",
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Internet, mobile phone, etc.",
                            Name = "Connection"
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Course, etc.",
                            Name = "Education"
                        },
                        new
                        {
                            Id = 5,
                            Comment = "",
                            Name = "Health"
                        },
                        new
                        {
                            Id = 6,
                            Comment = "",
                            Name = "Utillities"
                        },
                        new
                        {
                            Id = 7,
                            Comment = "Ticket, etc.",
                            Name = "Transport"
                        },
                        new
                        {
                            Id = 8,
                            Comment = "",
                            Name = "Services"
                        },
                        new
                        {
                            Id = 9,
                            Comment = "",
                            Name = "Gifts"
                        },
                        new
                        {
                            Id = 10,
                            Comment = "Movie, theater, zoo, etc.",
                            Name = "Entertainment"
                        },
                        new
                        {
                            Id = 11,
                            Comment = "Repair, fuel, etc.",
                            Name = "Car"
                        },
                        new
                        {
                            Id = 12,
                            Comment = "Health, life, car, house, etc.",
                            Name = "Ensurance"
                        },
                        new
                        {
                            Id = 13,
                            Comment = "Germany, USA, Turkey, Egypt, etc.",
                            Name = "Vacation"
                        });
                });

            modelBuilder.Entity("MyBudget.Models.Income", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IncomeTypeId")
                        .HasColumnType("int");

                    b.Property<float>("Sum")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("IncomeTypeId");

                    b.ToTable("Incomes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Good job",
                            Date = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 1,
                            Sum = 1000f
                        },
                        new
                        {
                            Id = 2,
                            Comment = "",
                            Date = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 2,
                            Sum = 100f
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Good job",
                            Date = new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 1,
                            Sum = 1000f
                        },
                        new
                        {
                            Id = 4,
                            Comment = "",
                            Date = new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 3,
                            Sum = 10f
                        },
                        new
                        {
                            Id = 5,
                            Comment = "Good job",
                            Date = new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 1,
                            Sum = 1000f
                        },
                        new
                        {
                            Id = 6,
                            Comment = "",
                            Date = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 4,
                            Sum = 1f
                        },
                        new
                        {
                            Id = 7,
                            Comment = "Good job",
                            Date = new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 1,
                            Sum = 1000f
                        },
                        new
                        {
                            Id = 8,
                            Comment = "",
                            Date = new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 2,
                            Sum = 100f
                        },
                        new
                        {
                            Id = 9,
                            Comment = "Good job",
                            Date = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 1,
                            Sum = 1000f
                        },
                        new
                        {
                            Id = 10,
                            Comment = "",
                            Date = new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 3,
                            Sum = 10f
                        },
                        new
                        {
                            Id = 11,
                            Comment = "Good job",
                            Date = new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 1,
                            Sum = 1000f
                        },
                        new
                        {
                            Id = 12,
                            Comment = "",
                            Date = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IncomeTypeId = 4,
                            Sum = 1f
                        });
                });

            modelBuilder.Entity("MyBudget.Models.IncomeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("IncomeTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Main money",
                            Name = "Salary"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Additional money",
                            Name = "Part-time job"
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Excellent money",
                            Name = "Royalty"
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Nice money",
                            Name = "Gift"
                        });
                });

            modelBuilder.Entity("MyBudget.Models.Expense", b =>
                {
                    b.HasOne("MyBudget.Models.ExpenseType", "ExpenseType")
                        .WithMany()
                        .HasForeignKey("ExpenseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenseType");
                });

            modelBuilder.Entity("MyBudget.Models.Income", b =>
                {
                    b.HasOne("MyBudget.Models.IncomeType", "IncomeType")
                        .WithMany()
                        .HasForeignKey("IncomeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncomeType");
                });
#pragma warning restore 612, 618
        }
    }
}
