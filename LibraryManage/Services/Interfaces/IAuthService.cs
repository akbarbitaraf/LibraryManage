using LibraryManage.Entities.DTO;

namespace LibraryManage.Services.Interfaces
{
    public interface IAuthService 
    {
        Task<MemberLoginRes> Login(MemberLoginReq req);
    }
}
