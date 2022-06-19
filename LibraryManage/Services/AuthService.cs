using AutoMapper;
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
        private readonly IMapper _mapper;

        public AuthService(LibraryManageContext libraryManageContext , IMapper mapper)
        {
            _libraryManageContext = libraryManageContext;
            this._mapper = mapper;
            _repositoryManager = new RepositoryManager(_libraryManageContext ,_mapper); 
        }
        public async Task<MemberLoginRes> Login(MemberLoginReq req)
        {
           string userName = req.userName;
            string password = req.password;
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new Exception("UserName Is Empty");
            }
            if (string.IsNullOrWhiteSpace(password)) 
            { 
                throw new Exception("Password Is Empty");
            }

            var result =  await _repositoryManager.MemberLogin.Login(userName,password);
            var mapper = _mapper.Map<MemberLoginRes>(result);
            return mapper;


        }
    }
}
