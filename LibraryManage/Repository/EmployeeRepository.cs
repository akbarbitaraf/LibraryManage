using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;
using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;

namespace LibraryManage.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly LibraryManageContext _libraryManageContext;

        public EmployeeRepository(LibraryManageContext libraryManageContext)
        {
            this._libraryManageContext = libraryManageContext;
        }

        public void CreateAuthors(Authors authors)
        {
            _libraryManageContext.Authors.Add(authors);
            _libraryManageContext.SaveChanges();
        }

        public void CreateCategories(string CategoryTitle)
        {
            _libraryManageContext.Categories.Add(new Categories() { CategoryName = CategoryTitle });
            _libraryManageContext.SaveChanges();


        }

        public async Task<TranslatorRes> CreateTranslator(Translators translators)
        {
            var result = await _libraryManageContext.Translators.AddAsync(translators);
            _libraryManageContext.SaveChanges();
            return new TranslatorRes { Translator_ID = result.Entity.Translator_ID};
        }

        public void DeleteAuthor(Authors authors)
        {
            var author = _libraryManageContext.Authors.Where(a=>a.Author_ID ==authors.Author_ID).FirstOrDefault();
            if (author != null)
                _libraryManageContext.Authors.Remove(author);

            _libraryManageContext.SaveChanges(); 
        }

        public void DeleteCategories(long categoryId)
        {
            var categories =  _libraryManageContext.Categories.Where(c => c.Category_ID == categoryId).FirstOrDefault();
            if (categories is not null)
                _libraryManageContext.Categories.Remove((Categories)categories);


            _libraryManageContext.SaveChanges(); 
        }

        public bool DeleteTranslator(int translatorID)
        {
            var resuslt = _libraryManageContext.Translators.Where(x=>x.Translator_ID == translatorID).FirstOrDefault();
            if (resuslt is null)
                return false;

            _libraryManageContext.Translators.Remove(resuslt);

            _libraryManageContext.SaveChanges();
            return true;
        }

        public List<Authors> GetAllAuthors()=>
         _libraryManageContext.Authors.ToList();
        

        public List<Categories> GetAllCategories()=>
            _libraryManageContext.Categories.ToList();

        public List<Translators> GetAllTranslators()
        {
           return  _libraryManageContext.Translators.ToList();
        }

        public Categories GetCategoriesByID(long categoryID)=>
            _libraryManageContext.Categories.Where(c=>c.Category_ID == categoryID).FirstOrDefault();

        public void UpdateAuthors(Authors authors)
        {
            _libraryManageContext.Authors.Update(authors);
            _libraryManageContext.SaveChanges(); 
        }
        public bool UpdateTranslator(Translators translators)
        {
          var result =_libraryManageContext.Translators.Update(translators);
            _libraryManageContext.SaveChanges();
            if (result is not null)
            {
                return true; 
            }
            return false; 
        }
    }
}
