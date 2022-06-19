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
    public class MemberLoginRepository : RepositoryBase<MemberLogin>, IMemberLoginRepository
    {
        public MemberLoginRepository(LibraryManageContext libraryManageContext) :base(libraryManageContext)
        {
            this._libraryManageContext = libraryManageContext;
        }


        public async Task<MemberLogin> Login(string userName, string password)
        {
           var result = _libraryManageContext.MemberLogins.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
            return  result;

        }

    }
}
