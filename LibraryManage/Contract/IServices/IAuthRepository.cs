using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;

namespace LibraryManage.Contract.IServices
{
    public interface IAuthRepository
    {
        public Task<EmployeeLogin> Login(string userName, string password);
        public Task<string> ResetPasswordLogin(string email, string newPassword);
        public Task<string> ResetPasswordAfterLogin(ResetPasswordLoginReq req , string email);

    }
}
