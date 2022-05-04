using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;
using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;
using LibraryManage.Repository;
using LibraryManage.Services.Interfaces;

namespace LibraryManage.Services
{
    public class AuthService : IAuthService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly LibraryManageContext _libraryManageContext; 

        public AuthService(LibraryManageContext libraryManageContext)
        {
            _libraryManageContext = libraryManageContext;
            _repositoryManager = new RepositoryManager(_libraryManageContext); 
        }
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
            var result = ((MemberLoginRepository)_repositoryManager.MemberLogin).FindAllCondition(a=>a.UserName == userName && a.Password ==password, false).ToList(); 
           

            return null; 

        }
    }
}
