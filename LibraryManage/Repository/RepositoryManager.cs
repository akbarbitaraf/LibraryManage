using AutoMapper;
using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;

namespace LibraryManage.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private LibraryManageContext _libraryManageContext;
        private IAuthRepository _AuthRepository;
        private IOperationRepository _OperationRepository;
        private IEmployeeRepository _EmployeeRepository;
       

        public RepositoryManager(LibraryManageContext libraryManageContext)
        {
            _libraryManageContext = libraryManageContext;
        }
        public IAuthRepository AuthRepository
        { 
    get { if (_AuthRepository == null)
                    _AuthRepository = new AuthRepository(_libraryManageContext); 
    return _AuthRepository;
                        }
        }

        public IOperationRepository operationRepository {

            get
            {
                if (_OperationRepository == null)
                    _OperationRepository = new OperationRepository(_libraryManageContext);
                return _OperationRepository;

            }

        }

        public IEmployeeRepository employeeRepository
        {
            get
            {
                if (_EmployeeRepository == null) _EmployeeRepository = new EmployeeRepository(_libraryManageContext);
                return (_EmployeeRepository);

               
            }
        }

        public void Save() => _libraryManageContext.SaveChanges();
        
    }
}
