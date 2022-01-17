using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBudget.Migrations
{
    public partial class AddForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeTypes_IncomeTypeId",
                table: "Incomes");

            migrationBuilder.AlterColumn<int>(
                name: "IncomeTypeId",
                table: "Incomes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseTypeId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "Id", "Comment", "Name" },
                values: new object[,]
                {
                    { 1, "Butter, bread, milk, etc.", "Food" },
                    { 13, "Germany, USA, Turkey, Egypt, etc.", "Vacation" },
                    { 12, "Health, life, car, house, etc.", "Ensurance" },
                    { 11, "Repair, fuel, etc.", "Car" },
                    { 10, "Movie, theater, zoo, etc.", "Entertainment" },
                    { 8, "", "Services" },
                    { 9, "", "Gifts" },
                    { 6, "", "Utillities" },
                    { 5, "", "Health" },
                    { 4, "Course, etc.", "Education" },
                    { 3, "Internet, mobile phone, etc.", "Connection" },
                    { 2, "Jacket, T-shirt, socks etc.", "Clothes" },
                    { 7, "Ticket, etc.", "Transport" }
                });

            migrationBuilder.InsertData(
                table: "IncomeTypes",
                columns: new[] { "Id", "Comment", "Name" },
                values: new object[,]
                {
                    { 3, "Excellent money", "Royalty" },
                    { 1, "Main money", "Salary" },
                    { 2, "Additional money", "Part-time job" },
                    { 4, "Nice money", "Gift" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Comment", "Date", "ExpenseTypeId", "Sum" },
                values: new object[,]
                {
                    { 1, "Bread", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10f },
                    { 12, "Life", new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 120f },
                    { 11, "Fuel", new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 110f },
                    { 10, "Theater", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100f },
                    { 9, "Wife", new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 90f },
                    { 8, "", new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 80f },
                    { 13, "USA", new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 130f },
                    { 6, "", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 60f },
                    { 5, "", new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 50f },
                    { 4, "Course", new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 40f },
                    { 3, "Internet", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 30f },
                    { 2, "Socks", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 20f },
                    { 7, "Bus", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 70f }
                });

            migrationBuilder.InsertData(
                table: "Incomes",
                columns: new[] { "Id", "Comment", "Date", "IncomeTypeId", "Sum" },
                values: new object[,]
                {
                    { 10, "", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10f },
                    { 4, "", new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10f },
                    { 8, "", new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100f },
                    { 2, "", new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100f },
                    { 11, "Good job", new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000f },
                    { 5, "Good job", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000f },
                    { 7, "Good job", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000f },
                    { 3, "Good job", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000f },
                    { 1, "Good job", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000f },
                    { 6, "", new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1f },
                    { 9, "Good job", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000f },
                    { 12, "", new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1f }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeTypes_IncomeTypeId",
                table: "Incomes",
                column: "IncomeTypeId",
                principalTable: "IncomeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_IncomeTypes_IncomeTypeId",
                table: "Incomes");

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Incomes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExpenseTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IncomeTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "IncomeTypeId",
                table: "Incomes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExpenseTypeId",
                table: "Expenses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_IncomeTypes_IncomeTypeId",
                table: "Incomes",
                column: "IncomeTypeId",
                principalTable: "IncomeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
