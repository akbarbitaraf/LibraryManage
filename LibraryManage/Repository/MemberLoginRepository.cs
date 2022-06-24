using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;
using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;
using Microsoft.EntityFrameworkCore;

namespace LibraryManage.Repository
{
    public class AuthRepository : RepositoryBase<EmployeeLogin>, IAuthRepository
    {
        public AuthRepository(LibraryManageContext libraryManageContext) :base(libraryManageContext)
        {
            this._libraryManageContext = libraryManageContext;
        }


        public async Task<EmployeeLogin> Login(string userName, string password)
        {
           var result = _libraryManageContext.EmployeeLogins.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
            return  result;

        }

        public async Task<string> ResetPasswordLogin(string email, string newPassword)
        {
            var employeeId = GetEmployeeByEmail(email);
            var emp = _libraryManageContext.EmployeeLogins.Where(c=>c.Employee_ID == employeeId).FirstOrDefault();
            if (emp == null)
            {
                throw new Exception("This is User Cannt Update Password"); 
            }
            emp.Password = newPassword;
            await _libraryManageContext.SaveChangesAsync();
            return  "Update Successfull";


        }
        public int GetEmployeeByEmail(string email)
        {
            var emp = _libraryManageContext.Employees.Where(c => c.EmailAddress == email).Select(c => c.Employee_ID).FirstOrDefault();
            if (emp == 0)
            {
                throw new Exception("Email is not Valid"); 
            }
            return emp;
        }

        public async Task<string> ResetPasswordAfterLogin(ResetPasswordLoginReq req, string email)
        {
            var emp =GetEmployeeByEmail(email);
            if (emp ==0)
            {
                throw new Exception("Email is not Valid");
            }
            var employeeLogin = _libraryManageContext.EmployeeLogins.Where(c=>c.Employee_ID ==emp && c.Password == req.CurrentPassword).FirstOrDefault();
            return employeeLogin != null ? employeeLogin.Password = req.NewPassword : throw new Exception("Password Is Incorrecnty"); 
            await _libraryManageContext.SaveChangesAsync();
            return "SuccessFull Update Password";
        }
    }
}
