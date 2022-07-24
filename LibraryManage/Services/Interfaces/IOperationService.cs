using LibraryManage.Entities.DTO;

namespace LibraryManage.Services.Interfaces
{
    public interface IOperationService
    {

        public void CreateCategory(string CategoryTitle); 
        public List<CategoriesRes> GetAllCategories();
        public long GetCategoryCount(string CategoryTitle);
        public CategoriesRes GetCategoryByID(long category);


    }
}
