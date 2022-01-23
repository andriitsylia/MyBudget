using AutoMapper;
using DAL.Entities;
using BLL.Dtos;
using MyBudget.Dtos;

namespace MyBudget.Profiles
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<IncomeTypeDto, IncomeTypeReadDto>();
            CreateMap<IncomeTypeCreateDto, IncomeTypeDto>();
            CreateMap<IncomeTypeUpdateDto, IncomeTypeDto>();

            CreateMap<IncomeDto, IncomeReadDto>();
            CreateMap<IncomeCreateDto, IncomeDto>();
            CreateMap<IncomeUpdateDto, IncomeDto>();

            CreateMap<ExpenseTypeDto, ExpenseTypeReadDto>();
            CreateMap<ExpenseTypeCreateDto, ExpenseTypeDto>();
            CreateMap<ExpenseTypeUpdateDto, ExpenseTypeDto>();

            CreateMap<ExpenseDto, ExpenseReadDto>();
            CreateMap<ExpenseCreateDto, ExpenseDto>();
            CreateMap<ExpenseUpdateDto, ExpenseDto>();


            //CreateMap<Income, IncomeReadDto>();
            //CreateMap<IncomeType, IncomeTypeReadDto>();
            //CreateMap<Expense, ExpenseReadDto>();
            //CreateMap<ExpenseType, ExpenseTypeReadDto>();

            //CreateMap<IncomeCreateDto, Income>();
            //CreateMap<IncomeTypeCreateDto, IncomeType>();
            //CreateMap<ExpenseCreateDto, Expense>();
            //CreateMap<ExpenseTypeCreateDto, ExpenseType>();

            //CreateMap<IncomeUpdateDto, Income>();
            //CreateMap<IncomeTypeUpdateDto, IncomeType>();
            //CreateMap<ExpenseUpdateDto, Expense>();
            //CreateMap<ExpenseTypeUpdateDto, ExpenseType>();
        }
    }
}
