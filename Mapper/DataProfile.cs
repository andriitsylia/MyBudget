using AutoMapper;
using DAL.Entities;
using DTO.Expense;
using DTO.ExpenseType;
using DTO.Income;
using DTO.IncomeType;

namespace Mapper
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<IncomeType, IncomeTypeDto>().ReverseMap().ForMember(et => et.Id, options => options.Ignore());
            CreateMap<Income, IncomeDto>().ReverseMap().ForMember(et => et.Id, options => options.Ignore());
            CreateMap<ExpenseType, ExpenseTypeDto>().ReverseMap().ForMember(et => et.Id, options => options.Ignore());
            CreateMap<Expense, ExpenseDto>().ReverseMap().ForMember(et => et.Id, options => options.Ignore());

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
