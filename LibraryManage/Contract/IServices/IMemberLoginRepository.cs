using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;

namespace LibraryManage.Contract.IServices
{
    public interface IMemberLoginRepository
    {
        public Task<MemberLogin> Login(string userName, string password);

    }
}
