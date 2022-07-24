using AutoMapper;
using LibraryManage.Contract.IServices;
using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;
using LibraryManage.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManage.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        //constructer
        public EmployeesService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._mapper = mapper;
         
        }
        // Categories
        public void CreateCategories(string CategoryTitle)=>
                   _repositoryManager.employeeRepository.CreateCategories(CategoryTitle);

        public void DeleteCategories(long CategoryId)=>
            _repositoryManager.employeeRepository.DeleteCategories(CategoryId);
        public CategoriesRes GetCategoriesByID(long category)
        {
            var result = _repositoryManager.employeeRepository.GetCategoriesByID(category);
            var mapper = _mapper.Map<CategoriesRes>(result);
            return mapper;

        }
        public List<CategoriesRes> GetAllCategories()
        {
            var result = _repositoryManager.operationRepository.GetAllCategories();
            
            var mapper =  _mapper.Map<List<CategoriesRes>>(result);

            return mapper;
        }

        public void CreateAuthors(AuthorReq authorReq)
        {
            var mapper = _mapper.Map<Authors>(authorReq);
            _repositoryManager.employeeRepository.CreateAuthors(mapper);


        }

        public void UpdateAuthors(AuthorReq authors)
        {
            var mapper  = _mapper.Map<Authors>(authors);
            _repositoryManager.employeeRepository.UpdateAuthors(mapper);
        }

        public List<Authors> GetAllAuthors()
        {
            return _repositoryManager.employeeRepository.GetAllAuthors();

        }

        public void DeleteAuthor(AuthorReq authors)
        {
            var mapper = _mapper.Map<Authors>(authors);

            _repositoryManager.employeeRepository.DeleteAuthor(mapper);
        }

        public Task<TranslatorRes> CreateTranslator(TranslatorReq translators)
        {
            var mapper = _mapper.Map<Translators>(translators);
           return _repositoryManager.employeeRepository.CreateTranslator(mapper);
        }

        public List<Translators> GetAllTranslators()
        {
           return _repositoryManager.employeeRepository.GetAllTranslators();
        }

        public bool DeleteTranslator(int translatorID)
        {
           return _repositoryManager.employeeRepository.DeleteTranslator(translatorID);
        }

        public bool UpdateTranslator(TranslatorReq translators)
        {
            var mapper =_mapper.Map<Translators>(translators);
            return _repositoryManager.employeeRepository.UpdateTranslator(mapper);
        }
    }
}
