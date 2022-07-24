using LibraryManage.Entities.DB;

namespace LibraryManage.Entities.DTO
{
    public class AuthorReq
    {
        public int Id { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public bool AuthorGender { get; set; }
        //public Translators Translators { get; set; }

        //public Publishers Publishers { get; set; }


    }
}
