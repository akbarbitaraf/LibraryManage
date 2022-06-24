using AutoMapper;
using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;

namespace LibraryManage.Entities.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeLogin, EmployeeLoginRes>()
                .ForMember(x =>x.userName, a => a.MapFrom(y => y.UserName))
                .ForMember(x=>x.employeeId , a=>a.MapFrom(y=>y.Employee_ID))
                ; 
        }
    }
}
