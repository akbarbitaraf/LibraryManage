using System.Security.Claims;
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
        private readonly IMapper _mapper;
        private readonly IJwtAuthManager _jwtAuthManager;

        public AuthService(IRepositoryManager repositoryManager, IMapper mapper, IJwtAuthManager jwtAuthManager)
        {
            this._mapper = mapper;
            this._jwtAuthManager = jwtAuthManager;
            _repositoryManager = repositoryManager;
        }
        public async Task<EmployeeLoginRes> Login(EmployeeLoginReq req)
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

            var result =  await _repositoryManager.AuthRepository.Login(userName,password);
            if(result is null)
            {
                throw new Exception("Not Found User , Try Again"); 
            }
            var claims = new[]
                        {
                    new Claim(ClaimTypes.Name, result.EmployeeLogin_ID.ToString()),
                    new Claim(ClaimTypes.Role, "Employee")
            };
            var jwtresult = _jwtAuthManager.GenerateTokens(result.UserName, claims, DateTime.UtcNow);

            var mapper = _mapper.Map<EmployeeLoginRes>(result);
            mapper.accessToken = jwtresult.access_token; 

            return mapper;


        }

        public Task<string> ResetPasswordAfterLogin(ResetPasswordLoginReq req, string email)
        {

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email is  Empty");
            }
            if (string.IsNullOrWhiteSpace(req.CurrentPassword) || string.IsNullOrWhiteSpace(req.NewPassword))
            {
                throw new Exception("Password is Empty");
            }
            if (req.CurrentPassword == req.NewPassword)
            {
                throw new Exception("This Password has been used before");
            }
            var result = _repositoryManager.AuthRepository.ResetPasswordAfterLogin(req,email);
            return result;
        }

        public Task<string> ResetPasswordLogin(string email, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email is  Empty"); 
            }
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                throw new Exception("Password is Empty"); 
            }
            var result = _repositoryManager.AuthRepository.ResetPasswordLogin(email, newPassword);
            return result;
        }
    }
}
