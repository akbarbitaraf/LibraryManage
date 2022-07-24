using LibraryManage.Entities.DB;

namespace LibraryManage.Entities.DTO
{
    public class CategoriesRes
    {
        public int Category_ID { get; set; }
        public string CategoryName { get; set; }

        public static explicit operator CategoriesRes(List<Categories> v)
        {
            throw new NotImplementedException();
        }
    }
}
