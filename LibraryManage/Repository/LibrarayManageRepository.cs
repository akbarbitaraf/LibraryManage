using LibraryManage.Entities.Context;

namespace LibraryManage.Repository
{
    public class LibrarayManageRepository
    {
        private LibraryManageContext _LibraryManageContext { get; set; }
        public LibrarayManageRepository(LibraryManageContext  libraryManageContext)
        {
            _LibraryManageContext = libraryManageContext;
        }


        public  IQueryable<T>  Login<T>(string userName , string password)
        {
           return (IQueryable<T>)_LibraryManageContext.MemberLogins.Where(opt => opt.UserName == userName && opt.Password == password); 


        }

    }
}
