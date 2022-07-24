using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;

namespace LibraryManage.Contract.IServices
{
    public interface IEmployeeRepository
    {
        //Categories
        public void CreateCategories(string CategoryTitle);
        public void DeleteCategories(long CategoryId);
        public List<Categories> GetAllCategories();
        public Categories GetCategoriesByID(long categoryID);
            
        //Authors
        public void CreateAuthors(Authors authors);
        public void UpdateAuthors(Authors authors);
        public List<Authors> GetAllAuthors();
        public void DeleteAuthor(Authors authors);

        //Translator    
        public Task<TranslatorRes> CreateTranslator(Translators translators);
        public List<Translators> GetAllTranslators(); //  set in automapper ???
        public bool DeleteTranslator(int translatorID);
        public bool UpdateTranslator(Translators translators);
    }
}
