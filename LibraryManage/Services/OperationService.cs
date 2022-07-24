using AutoMapper;
using LibraryManage.Contract.IServices;
using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;
using LibraryManage.Services.Interfaces;

namespace LibraryManage.Services
{
    public class OperationService : IOperationService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public OperationService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._mapper = mapper;
         
        }
        public List<CategoriesRes> GetAllCategories()
        {
            var result = _repositoryManager.operationRepository.GetAllCategories();
            
            var mapper =  _mapper.Map<List<CategoriesRes>>(result);

            return mapper;
        }
        //Categories
        public CategoriesRes GetCategoryByID(long category)
        {
            throw new NotImplementedException();
        }

        public long GetCategoryCount(string CategoryTitle)
        {
            throw new NotImplementedException();
        }

        public void CreateCategory(string CategoryTitle)
        {
           _repositoryManager.operationRepository.CreateCategory(CategoryTitle);
        }

        /// Authour
        public void CreateAuthor(String AuthourTitle)
        {

        }
        public void GetAuthourByID()
        {

        }
        public void GetAuthorWithSearchCode() { }
        public void DeleteAuthour(long AuthourID)
        {

        }

        //BookStatus
        //Areas
        //Configuration
        //Libraries
        //Publisher
        //Shelf
        //Translator
        //transactionTypes
        //BooksLoansStatus
        //BooksStatus
        //Employeeroles
        //EmployeeStatus






    }
}
