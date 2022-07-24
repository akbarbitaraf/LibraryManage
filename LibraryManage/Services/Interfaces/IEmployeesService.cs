using LibraryManage.Entities.DB;
using LibraryManage.Entities.DTO;

namespace LibraryManage.Services.Interfaces
{
    public interface IEmployeesService  
    {
        //Categories
        public void CreateCategories(string CategoryTitle);
        public void DeleteCategories(long CategoryId);
        public List<CategoriesRes> GetAllCategories();
        public CategoriesRes GetCategoriesByID(long category);
        //Authors
        public void CreateAuthors(AuthorReq authors);
        public void UpdateAuthors(AuthorReq authors);
        public List<Authors> GetAllAuthors();
        public void DeleteAuthor(AuthorReq authors);

        //Translator    
        public Task<TranslatorRes> CreateTranslator(TranslatorReq translators);
        public List<Translators> GetAllTranslators(); //  set in automapper ???
        public bool DeleteTranslator(int translatorID);
        public bool UpdateTranslator(TranslatorReq translators);

        ////Areas
        //public void AddAreas(AreaReq areaReq);
        //public void ModifyAreas(AreaReq areaReq);
        //public void DeleteAreas(AreaReq areaReq);
        ////Librariess
        //public void AddLibraries(LibraryReq libraryReq);
        //public void DeleteLibraries(LibraryReq libraryReq);
        //public void ModifyLibraries(LibraryReq libraryReq);
        //// PaymentTypes
        //public void CreatePaymentTypes(PaymentTypeReq paymentTypeReq);
        //public void DeletePaymentTypes(PaymentTypeReq paymentTypeReq);
        //public void UpdatePaymentTypes(PaymentTypeReq paymentTypeReq );
        ////shelfs
        //public void CreateShelfs(ShelfReq shelfReq);
        //public void DeleteShelfs(ShelfReq shelfReq);
        //public void UpdateShelfs(ShelfReq shelfReq);
        ////Publisher
        //public void CreatePublisher(PublishersReq publishersReq);
        //public void DeletePublisher(PublishersReq publishersReq);
        //public void UpdatePublisher(PublishersReq publishersReq);

        ////Translator    
        //public void CreateTranslator(TranslatorReq translatorReq);
        //public List<TranslatorReq> GetAllTranslator(); //  set in automapper ???
        //public bool DeleteTranslator(TranslatorReq translatorReq);
        //public void UpdateTranslator(TranslatorReq translatorReq);
        ////MemberStatus
        //public void CreateMemberStatus(MemberStatusReq memberStatusReq);
        //public bool DeleteMemberStatus(MemberStatusReq memberStatusReq);
        //public bool UpdateMemberStatus(MemberStatusReq memberStatusReq);
        ////EmployeeStatus
        //public void CreateEmployeeStatus(EmployeeStatusReq employeeStatusReq);
        //public bool DeleteEmployeeStatus(EmployeeStatusReq employeeStatusReq); 
        //public bool UpdateEmployeeStatus(EmployeeStatusReq employeeStatusReq);
        ////EmployeesRoles
        //public void CreateEmployeeRoles(EmployeeRoleReq employeeRoleReq);
        //public bool DeleteEmployeeRoles(EmployeeRoleReq employeeRoleReq);
        //public bool UpdateEmployeeRoles(EmployeeRoleReq employeeRoleReq);
        ////Books
        //public void AddBooks(BooksReq booksReq); 
        //public bool DeleteBooks(BooksReq booksReq);
        //public bool ModifyBooks(BooksReq booksReq);
        //// Book_in_shelfs
        //public void Add_Book_in_shelfs(Books_In_ShelfsReq books_In_ShelfsReq);
        //public bool Delete_Book_in_shelfs(Books_In_ShelfsReq books_In_ShelfsReq);
        //public bool Update_Book_in_shelfs(Books_In_ShelfsReq books_In_ShelfsReq); 














    }
}
