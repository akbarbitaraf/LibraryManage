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
                .ForMember(x=>x.employeeId , a=>a.MapFrom(y=>y.Employee_ID));

            CreateMap<Categories,CategoriesRes>();
            CreateMap<Authors, AuthorRes>();
            CreateMap<AuthorReq ,Authors>()
                .ForMember(x=>x.Author_ID,a=>a.MapFrom(y=>y.Id))
                .ForMember(x=>x.AuthorFirstName ,a=>a.MapFrom(y=>y.AuthorFirstName))
                .ForMember(x=>x.AuthorLastName , a=>a.MapFrom(y=>y.AuthorLastName))
                .ForMember(x=>x.AuthorGender , a=>a.MapFrom(y=>y.AuthorGender));
            CreateMap<TranslatorReq, Translators>()
                   .ForMember(x => x.FirstName, a => a.MapFrom(y => y.FirstName))
                   .ForMember(x => x.LastName, a => a.MapFrom(y => y.LastName))
                   .ForMember(x => x.Mobile, a => a.MapFrom(y => y.Mobile))
                   .ForMember(x => x.Phone, a => a.MapFrom(y => y.Phone))
                   .ForMember(x => x.Gender, a => a.MapFrom(y => y.Gender));


              


        }
       
    }
}
