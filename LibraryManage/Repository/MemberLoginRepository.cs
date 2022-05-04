using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;
using LibraryManage.Entities.DB;

namespace LibraryManage.Repository
{
    public class MemberLoginRepository : RepositoryBase<MemberLogin>, IMemberLoginRepository
    {
        public MemberLoginRepository(LibraryManageContext libraryManageContext) : base(libraryManageContext)
        {
        }
    }
}
