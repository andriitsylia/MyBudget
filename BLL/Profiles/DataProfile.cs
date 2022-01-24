using AutoMapper;
using DAL.Entities;
using BLL.Dtos;

namespace BLL.Profiles
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<IncomeType, IncomeTypeDto>().ReverseMap()
                .ForMember(et => et.Id, options => options.Ignore());

            CreateMap<Income, IncomeDto>().ReverseMap()
                .ForMember(et => et.Id, options => options.Ignore());

            CreateMap<ExpenseType, ExpenseTypeDto>().ReverseMap()
                .ForMember(et => et.Id, options => options.Ignore());

            CreateMap<Expense, ExpenseDto>().ReverseMap()
                .ForMember(et => et.Id, options => options.Ignore());
        }
    }
}
