using AutoMapper;
using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;

namespace LibraryManage.Entities.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MemberLogin, MemberLoginRes>()
                .ForMember(x =>x.userName, a => a.MapFrom(y => y.UserName))
                .ForMember(x=>x.memberId , a=>a.MapFrom(y=>y.Member_ID))
                ; 
        }
    }
}
