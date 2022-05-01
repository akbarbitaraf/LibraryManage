using LibraryManage.Entities.DTO;
using LibraryManage.Services.Interfaces;

namespace LibraryManage.Services
{
    public class AuthService : IAuthService
    {

        public Task<MemberLoginRes> Login(MemberLoginReq req)
        {
           string userName = req.UserName;
            string password = req.Password;
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new Exception("UserName Is Empty");
            }
            if (string.IsNullOrWhiteSpace(password)) 
            { 
                throw new Exception("Password Is Empty");
            }
            

            return null; 

        }
    }
}
