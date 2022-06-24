using LibraryManage.Entities.DTO;

namespace LibraryManage.Services.Interfaces
{
    public interface IAuthService 
    {
        Task<EmployeeLoginRes> Login(EmployeeLoginReq req);
        Task<string> ResetPasswordLogin(string email, string newPassword);
        Task<string> ResetPasswordAfterLogin(ResetPasswordLoginReq req, string email);
    }
}
