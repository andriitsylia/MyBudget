using AutoMapper;
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
            CreateMap<IncomeTypeCreateDto, IncomeTypeReadDto>();
            CreateMap<IncomeTypeUpdateDto, IncomeTypeDto>();

            CreateMap<IncomeDto, IncomeReadDto>();
            CreateMap<IncomeCreateDto, IncomeDto>();
            CreateMap<IncomeCreateDto, IncomeReadDto>();
            CreateMap<IncomeUpdateDto, IncomeDto>();
            CreateMap<IncomeDateTotalDto, IncomeDateReportDto>().IncludeAllDerived();
            CreateMap<IncomeDateIntervalTotalDto, IncomeDateIntervalReportDto>().IncludeAllDerived();

            CreateMap<ExpenseTypeDto, ExpenseTypeReadDto>();
            CreateMap<ExpenseTypeCreateDto, ExpenseTypeDto>();
            CreateMap<ExpenseTypeCreateDto, ExpenseTypeReadDto>();
            CreateMap<ExpenseTypeUpdateDto, ExpenseTypeDto>();

            CreateMap<ExpenseDto, ExpenseReadDto>();
            CreateMap<ExpenseCreateDto, ExpenseDto>();
            CreateMap<ExpenseCreateDto, ExpenseReadDto>();
            CreateMap<ExpenseUpdateDto, ExpenseDto>();
            CreateMap<ExpenseDateTotalDto, ExpenseDateReportDto>().IncludeAllDerived();
            CreateMap<ExpenseDateIntervalTotalDto, ExpenseDateIntervalReportDto>().IncludeAllDerived();
        }
    }
}
