using AutoMapper;
using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;

namespace LibraryManage.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private LibraryManageContext _libraryManageContext;
        private readonly IMapper _mapper;
        private IAuthRepository _AuthRepository;

        public RepositoryManager(LibraryManageContext libraryManageContext , IMapper mapper)
        {
            _libraryManageContext = libraryManageContext;
            this._mapper = mapper;
        }
        public IAuthRepository AuthRepository
        { 
    get { if (_AuthRepository == null)
                    _AuthRepository = new AuthRepository(_libraryManageContext); 
    return _AuthRepository;
                        }
        }

        public void Save() => _libraryManageContext.SaveChanges();
        
    }
}
