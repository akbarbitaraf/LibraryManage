using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;

namespace LibraryManage.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private LibraryManageContext _libraryManageContext;
        private IMemberLoginRepository _MemberLoginRepository;

        public RepositoryManager(LibraryManageContext libraryManageContext)
        {
            _libraryManageContext = libraryManageContext;
        }
        public IMemberLoginRepository MemberLogin { 
    get { if (_MemberLoginRepository == null)
                    _MemberLoginRepository = new MemberLoginRepository(_libraryManageContext); 
    return _MemberLoginRepository;
                        }
        }

        public void Save() => _libraryManageContext.SaveChanges();
        
    }
}
