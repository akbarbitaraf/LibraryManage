using LibraryManage.Entities.DB;

namespace LibraryManage.Contract.IServices
{
    public interface IOperationRepository
    {
        public void CreateCategory(string categoryTitle);
        public List<Categories> GetAllCategories();
        public Categories GetCategoryByID(long category);
    }
}
