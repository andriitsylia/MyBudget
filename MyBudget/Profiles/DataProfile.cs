using AutoMapper;
using MyBudget.Dtos;
using MyBudget.Models;

namespace MyBudget.Profiles
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<Income, IncomeReadDto>();
            CreateMap<IncomeType, IncomeTypeReadDto>();
            CreateMap<Expense, ExpenseReadDto>();
            CreateMap<ExpenseType, ExpenseTypeReadDto>();

            CreateMap<IncomeCreateDto, Income>();
            CreateMap<IncomeTypeCreateDto, IncomeType>();
            CreateMap<ExpenseCreateDto, Expense>();
            CreateMap<ExpenseTypeCreateDto, ExpenseType>();
        }
    }
}
