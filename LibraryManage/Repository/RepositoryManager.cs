using AutoMapper;
using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;

namespace LibraryManage.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private LibraryManageContext _libraryManageContext;
        private readonly IMapper _mapper;
        private IMemberLoginRepository _MemberLoginRepository;

        public RepositoryManager(LibraryManageContext libraryManageContext , IMapper mapper)
        {
            _libraryManageContext = libraryManageContext;
            this._mapper = mapper;
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
