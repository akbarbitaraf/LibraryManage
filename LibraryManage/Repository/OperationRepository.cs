using LibraryManage.Contract.IServices;
using LibraryManage.Entities.Context;
using LibraryManage.Entities.DB;

namespace LibraryManage.Repository
{
    public class OperationRepository : RepositoryBase<Categories> , IOperationRepository
    {
        private readonly LibraryManageContext _libraryManageContext;
        public OperationRepository(LibraryManageContext libraryManageContext) : base(libraryManageContext) => this._libraryManageContext = libraryManageContext;

        public List<Categories> GetAllCategories()
        {
        return  _libraryManageContext.Categories.ToList();
        
        }

        public Categories GetCategoryByID(long category)
        {
      
            return _libraryManageContext.Categories.Where(c => c.Category_ID == category).FirstOrDefault();
        }
        public void CreateCategory(string categoryTitle)
        {
            if (_libraryManageContext.Categories.Where(c=>c.CategoryName == categoryTitle).FirstOrDefault() !=null )
            {
                throw new Exception("Error Exist This Category"); 
            }
            else
            {
                _libraryManageContext.Add(new Categories { CategoryName = categoryTitle }); 
                _libraryManageContext.SaveChanges();
            }
        }
    }
}
