using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManage.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "booksLoansStatuses",
                columns: table => new
                {
                    BookLoanStatus_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booksLoansStatuses", x => x.BookLoanStatus_ID);
                });

            migrationBuilder.CreateTable(
                name: "BooksStatuses",
                columns: table => new
                {
                    Bookstatus_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksStatuses", x => x.Bookstatus_ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesRoles",
                columns: table => new
                {
                    EmployeeRole_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesRoles", x => x.EmployeeRole_ID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesStatus",
                columns: table => new
                {
                    EmployeeStatus_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesStatus", x => x.EmployeeStatus_ID);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Library_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Library_ID);
                });

            migrationBuilder.CreateTable(
                name: "MembersAttachment",
                columns: table => new
                {
                    MemberAttachment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MASelfImage = table.Column<byte>(type: "tinyint", nullable: false),
                    MASelfBirthCertificate = table.Column<byte>(type: "tinyint", nullable: false),
                    MASelfNationalCertificate = table.Column<byte>(type: "tinyint", nullable: false),
                    MAGuarantor = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembersAttachment", x => x.MemberAttachment_ID);
                });

            migrationBuilder.CreateTable(
                name: "MembersStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MSTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembersStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentType_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayTypeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentType_ID);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Publisher_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisheAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Publisher_ID);
                });

            migrationBuilder.CreateTable(
                name: "TransactionsTypes",
                columns: table => new
                {
                    TransactionType_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TTTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionsTypes", x => x.TransactionType_ID);
                });

            migrationBuilder.CreateTable(
                name: "Translators",
                columns: table => new
                {
                    Translator_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translators", x => x.Translator_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeStatus_ID = table.Column<int>(type: "int", nullable: true),
                    EmployeeRole_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeesRoles_EmployeeRole_ID",
                        column: x => x.EmployeeRole_ID,
                        principalTable: "EmployeesRoles",
                        principalColumn: "EmployeeRole_ID");
                    table.ForeignKey(
                        name: "FK_Employees_EmployeesStatus_EmployeeStatus_ID",
                        column: x => x.EmployeeStatus_ID,
                        principalTable: "EmployeesStatus",
                        principalColumn: "EmployeeStatus_ID");
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Area_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Library_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Area_ID);
                    table.ForeignKey(
                        name: "FK_Areas_Libraries_Library_ID",
                        column: x => x.Library_ID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID");
                });

            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Configuration_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigurationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllowedLoanDays = table.Column<int>(type: "int", nullable: false),
                    AllowedLoanNumberBook = table.Column<int>(type: "int", nullable: false),
                    MulctDelayOneDayPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Library_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.Configuration_ID);
                    table.ForeignKey(
                        name: "FK_Configurations_Libraries_Library_ID",
                        column: x => x.Library_ID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID");
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Member_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Tel = table.Column<int>(type: "int", nullable: true),
                    MemberStatus_ID = table.Column<int>(type: "int", nullable: false),
                    MemberAttachment_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Member_ID);
                    table.ForeignKey(
                        name: "FK_Members_MembersAttachment_MemberAttachment_ID",
                        column: x => x.MemberAttachment_ID,
                        principalTable: "MembersAttachment",
                        principalColumn: "MemberAttachment_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Members_MembersStatus_MemberStatus_ID",
                        column: x => x.MemberStatus_ID,
                        principalTable: "MembersStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Author_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AuthorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorGender = table.Column<bool>(type: "bit", nullable: false),
                    Translator_ID = table.Column<int>(type: "int", nullable: true),
                    Publisher_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Author_ID);
                    table.ForeignKey(
                        name: "FK_Authors_Publishers_Publisher_ID",
                        column: x => x.Publisher_ID,
                        principalTable: "Publishers",
                        principalColumn: "Publisher_ID");
                    table.ForeignKey(
                        name: "FK_Authors_Translators_Translator_ID",
                        column: x => x.Translator_ID,
                        principalTable: "Translators",
                        principalColumn: "Translator_ID");
                });

            migrationBuilder.CreateTable(
                name: "Shelfs",
                columns: table => new
                {
                    Shelf_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelfs", x => x.Shelf_ID);
                    table.ForeignKey(
                        name: "FK_Shelfs_Areas_Area_ID",
                        column: x => x.Area_ID,
                        principalTable: "Areas",
                        principalColumn: "Area_ID");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Transaction_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentType_ID = table.Column<int>(type: "int", nullable: true),
                    TransactionType_ID = table.Column<int>(type: "int", nullable: true),
                    Employee_ID = table.Column<int>(type: "int", nullable: true),
                    Library_ID = table.Column<int>(type: "int", nullable: true),
                    Member_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Transaction_ID);
                    table.ForeignKey(
                        name: "FK_Transactions_Employees_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID");
                    table.ForeignKey(
                        name: "FK_Transactions_Libraries_Library_ID",
                        column: x => x.Library_ID,
                        principalTable: "Libraries",
                        principalColumn: "Library_ID");
                    table.ForeignKey(
                        name: "FK_Transactions_Members_Member_ID",
                        column: x => x.Member_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID");
                    table.ForeignKey(
                        name: "FK_Transactions_PaymentTypes_PaymentType_ID",
                        column: x => x.PaymentType_ID,
                        principalTable: "PaymentTypes",
                        principalColumn: "PaymentType_ID");
                    table.ForeignKey(
                        name: "FK_Transactions_TransactionsTypes_TransactionType_ID",
                        column: x => x.TransactionType_ID,
                        principalTable: "TransactionsTypes",
                        principalColumn: "TransactionType_ID");
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Book_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bookstatus_ID = table.Column<int>(type: "int", nullable: true),
                    Author_ID = table.Column<int>(type: "int", nullable: true),
                    CurrentStock = table.Column<int>(type: "int", nullable: true),
                    Publisher_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Book_ID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_Author_ID",
                        column: x => x.Author_ID,
                        principalTable: "Authors",
                        principalColumn: "Author_ID");
                    table.ForeignKey(
                        name: "FK_Books_BooksStatuses_Bookstatus_ID",
                        column: x => x.Bookstatus_ID,
                        principalTable: "BooksStatuses",
                        principalColumn: "Bookstatus_ID");
                    table.ForeignKey(
                        name: "FK_Books_Publishers_Publisher_ID",
                        column: x => x.Publisher_ID,
                        principalTable: "Publishers",
                        principalColumn: "Publisher_ID");
                });

            migrationBuilder.CreateTable(
                name: "Books_In_Shelfs",
                columns: table => new
                {
                    BooksInShelf_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book_ID = table.Column<int>(type: "int", nullable: true),
                    Shelf_ID = table.Column<int>(type: "int", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bookstatus_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books_In_Shelfs", x => x.BooksInShelf_ID);
                    table.ForeignKey(
                        name: "FK_Books_In_Shelfs_Books_Book_ID",
                        column: x => x.Book_ID,
                        principalTable: "Books",
                        principalColumn: "Book_ID");
                    table.ForeignKey(
                        name: "FK_Books_In_Shelfs_BooksStatuses_Bookstatus_ID",
                        column: x => x.Bookstatus_ID,
                        principalTable: "BooksStatuses",
                        principalColumn: "Bookstatus_ID");
                    table.ForeignKey(
                        name: "FK_Books_In_Shelfs_Shelfs_Shelf_ID",
                        column: x => x.Shelf_ID,
                        principalTable: "Shelfs",
                        principalColumn: "Shelf_ID");
                });

            migrationBuilder.CreateTable(
                name: "BooksCategories",
                columns: table => new
                {
                    BooksCategory_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_ID = table.Column<int>(type: "int", nullable: true),
                    Book_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksCategories", x => x.BooksCategory_ID);
                    table.ForeignKey(
                        name: "FK_BooksCategories_Books_Book_ID",
                        column: x => x.Book_ID,
                        principalTable: "Books",
                        principalColumn: "Book_ID");
                    table.ForeignKey(
                        name: "FK_BooksCategories_Categories_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "Categories",
                        principalColumn: "Category_ID");
                });

            migrationBuilder.CreateTable(
                name: "BookLoans",
                columns: table => new
                {
                    BookLoan_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookLoanStatus_ID = table.Column<int>(type: "int", nullable: true),
                    BooksInShelf_ID = table.Column<int>(type: "int", nullable: true),
                    Member_ID = table.Column<int>(type: "int", nullable: true),
                    MulcCurrentDelay = table.Column<int>(type: "int", nullable: true),
                    ReturnMulctDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookLoans", x => x.BookLoan_ID);
                    table.ForeignKey(
                        name: "FK_BookLoans_Books_In_Shelfs_BooksInShelf_ID",
                        column: x => x.BooksInShelf_ID,
                        principalTable: "Books_In_Shelfs",
                        principalColumn: "BooksInShelf_ID");
                    table.ForeignKey(
                        name: "FK_BookLoans_booksLoansStatuses_BookLoanStatus_ID",
                        column: x => x.BookLoanStatus_ID,
                        principalTable: "booksLoansStatuses",
                        principalColumn: "BookLoanStatus_ID");
                    table.ForeignKey(
                        name: "FK_BookLoans_Members_Member_ID",
                        column: x => x.Member_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Library_ID",
                table: "Areas",
                column: "Library_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Publisher_ID",
                table: "Authors",
                column: "Publisher_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Translator_ID",
                table: "Authors",
                column: "Translator_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BookLoans_BookLoanStatus_ID",
                table: "BookLoans",
                column: "BookLoanStatus_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BookLoans_BooksInShelf_ID",
                table: "BookLoans",
                column: "BooksInShelf_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BookLoans_Member_ID",
                table: "BookLoans",
                column: "Member_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Author_ID",
                table: "Books",
                column: "Author_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Bookstatus_ID",
                table: "Books",
                column: "Bookstatus_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Publisher_ID",
                table: "Books",
                column: "Publisher_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_In_Shelfs_Book_ID",
                table: "Books_In_Shelfs",
                column: "Book_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_In_Shelfs_Bookstatus_ID",
                table: "Books_In_Shelfs",
                column: "Bookstatus_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_In_Shelfs_Shelf_ID",
                table: "Books_In_Shelfs",
                column: "Shelf_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BooksCategories_Book_ID",
                table: "BooksCategories",
                column: "Book_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BooksCategories_Category_ID",
                table: "BooksCategories",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_Library_ID",
                table: "Configurations",
                column: "Library_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeRole_ID",
                table: "Employees",
                column: "EmployeeRole_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeStatus_ID",
                table: "Employees",
                column: "EmployeeStatus_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_MemberAttachment_ID",
                table: "Members",
                column: "MemberAttachment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_MemberStatus_ID",
                table: "Members",
                column: "MemberStatus_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Shelfs_Area_ID",
                table: "Shelfs",
                column: "Area_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Employee_ID",
                table: "Transactions",
                column: "Employee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Library_ID",
                table: "Transactions",
                column: "Library_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Member_ID",
                table: "Transactions",
                column: "Member_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentType_ID",
                table: "Transactions",
                column: "PaymentType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransactionType_ID",
                table: "Transactions",
                column: "TransactionType_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookLoans");

            migrationBuilder.DropTable(
                name: "BooksCategories");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Books_In_Shelfs");

            migrationBuilder.DropTable(
                name: "booksLoansStatuses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "TransactionsTypes");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Shelfs");

            migrationBuilder.DropTable(
                name: "EmployeesRoles");

            migrationBuilder.DropTable(
                name: "EmployeesStatus");

            migrationBuilder.DropTable(
                name: "MembersAttachment");

            migrationBuilder.DropTable(
                name: "MembersStatus");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "BooksStatuses");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Translators");

            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
