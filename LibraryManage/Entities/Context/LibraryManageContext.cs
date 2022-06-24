using LibraryManage.Entities.DB;
using Microsoft.EntityFrameworkCore;

namespace LibraryManage.Entities.Context
{
    public class LibraryManageContext:DbContext
    {
        public LibraryManageContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Areas> Areas { get; set; }
        public DbSet<Authors> Authors { get; set; } 
        public  DbSet<BookLoans> BookLoans { get; set; }
        public DbSet<Books> Books { get; set; } 
        public DbSet<Books_In_Shelfs> Books_In_Shelfs { get; set; }  
        public DbSet<BooksCategories> BooksCategories { get; set; } 
        public DbSet<BooksLoansStatus> booksLoansStatuses { get; set; } 
        public DbSet<BooksStatus> BooksStatuses { get; set; }   
        public DbSet<Categories> Categories { get; set; }   
        public DbSet<Configurations> Configurations { get; set; }   
        public DbSet<Employees> Employees { get; set; } 
        public DbSet<EmployeesRoles> EmployeesRoles { get; set; }   
        public DbSet<Libraries> Libraries { get; set; } 
        public DbSet<Members> Members { get; set; } 
        public DbSet<PaymentTypes> PaymentTypes { get; set; }   
        public DbSet<Publishers> Publishers { get; set; }   
        public DbSet<Shelfs> Shelfs { get; set; }   
        public DbSet<Transactions> Transactions { get; set; }       
        public DbSet<TransactionsTypes> TransactionsTypes { get; set; } 
        public DbSet<Translators> Translators { get; set; } 
        public DbSet<EmployeeLogin> EmployeeLogins { get; set; }

    }
}
