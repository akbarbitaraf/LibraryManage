﻿// <auto-generated />
using System;
using LibraryManage.Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManage.Migrations
{
    [DbContext(typeof(LibraryManageContext))]
    partial class LibraryManageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LibraryManage.Entities.DB.Areas", b =>
                {
                    b.Property<int>("Area_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Area_ID"), 1L, 1);

                    b.Property<int?>("Library_ID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Area_ID");

                    b.HasIndex("Library_ID");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Authors", b =>
                {
                    b.Property<int>("Author_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_ID"), 1L, 1);

                    b.Property<string>("AuthorFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AuthorGender")
                        .HasColumnType("bit");

                    b.Property<string>("AuthorLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Publisher_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Translator_ID")
                        .HasColumnType("int");

                    b.HasKey("Author_ID");

                    b.HasIndex("Publisher_ID");

                    b.HasIndex("Translator_ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.BookLoans", b =>
                {
                    b.Property<int>("BookLoan_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookLoan_ID"), 1L, 1);

                    b.Property<int?>("BookLoanStatus_ID")
                        .HasColumnType("int");

                    b.Property<int?>("BooksInShelf_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Member_ID")
                        .HasColumnType("int");

                    b.Property<int?>("MulcCurrentDelay")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnMulctDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookLoan_ID");

                    b.HasIndex("BookLoanStatus_ID");

                    b.HasIndex("BooksInShelf_ID");

                    b.HasIndex("Member_ID");

                    b.ToTable("BookLoans");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Books", b =>
                {
                    b.Property<int>("Book_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_ID"), 1L, 1);

                    b.Property<int?>("Author_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Bookstatus_ID")
                        .HasColumnType("int");

                    b.Property<int?>("CurrentStock")
                        .HasColumnType("int");

                    b.Property<int?>("Publisher_ID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Book_ID");

                    b.HasIndex("Author_ID");

                    b.HasIndex("Bookstatus_ID");

                    b.HasIndex("Publisher_ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Books_In_Shelfs", b =>
                {
                    b.Property<int>("BooksInShelf_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BooksInShelf_ID"), 1L, 1);

                    b.Property<int?>("Book_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Bookstatus_ID")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Shelf_ID")
                        .HasColumnType("int");

                    b.HasKey("BooksInShelf_ID");

                    b.HasIndex("Book_ID");

                    b.HasIndex("Bookstatus_ID");

                    b.HasIndex("Shelf_ID");

                    b.ToTable("Books_In_Shelfs");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.BooksCategories", b =>
                {
                    b.Property<int>("BooksCategory_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BooksCategory_ID"), 1L, 1);

                    b.Property<int?>("Book_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Category_ID")
                        .HasColumnType("int");

                    b.HasKey("BooksCategory_ID");

                    b.HasIndex("Book_ID");

                    b.HasIndex("Category_ID");

                    b.ToTable("BooksCategories");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.BooksLoansStatus", b =>
                {
                    b.Property<int>("BookLoanStatus_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookLoanStatus_ID"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookLoanStatus_ID");

                    b.ToTable("booksLoansStatuses");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.BooksStatus", b =>
                {
                    b.Property<int>("Bookstatus_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Bookstatus_ID"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bookstatus_ID");

                    b.ToTable("BooksStatuses");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Categories", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_ID"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Configurations", b =>
                {
                    b.Property<int>("Configuration_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Configuration_ID"), 1L, 1);

                    b.Property<int>("AllowedLoanDays")
                        .HasColumnType("int");

                    b.Property<int>("AllowedLoanNumberBook")
                        .HasColumnType("int");

                    b.Property<string>("ConfigurationTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Library_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("MulctDelayOneDayPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Configuration_ID");

                    b.HasIndex("Library_ID");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Employees", b =>
                {
                    b.Property<int>("Employee_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employee_ID"), 1L, 1);

                    b.Property<int?>("EmployeeRole_ID")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeStatus_ID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employee_ID");

                    b.HasIndex("EmployeeRole_ID");

                    b.HasIndex("EmployeeStatus_ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.EmployeesRoles", b =>
                {
                    b.Property<int>("EmployeeRole_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeRole_ID"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeRole_ID");

                    b.ToTable("EmployeesRoles");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.EmployeesStatus", b =>
                {
                    b.Property<int>("EmployeeStatus_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeStatus_ID"), 1L, 1);

                    b.Property<string>("ESTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeStatus_ID");

                    b.ToTable("EmployeesStatus");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Libraries", b =>
                {
                    b.Property<int>("Library_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Library_ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Library_ID");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.MemberLogin", b =>
                {
                    b.Property<int>("MemberLogin_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberLogin_ID"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Member_ID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberLogin_ID");

                    b.HasIndex("Member_ID");

                    b.ToTable("MemberLogins");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Members", b =>
                {
                    b.Property<int>("Member_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Member_ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MemberAttachment_ID")
                        .HasColumnType("int");

                    b.Property<int>("MemberStatus_ID")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Member_ID");

                    b.HasIndex("MemberAttachment_ID");

                    b.HasIndex("MemberStatus_ID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.MembersAttachment", b =>
                {
                    b.Property<int>("MemberAttachment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberAttachment_ID"), 1L, 1);

                    b.Property<byte>("MAGuarantor")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MASelfBirthCertificate")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MASelfImage")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MASelfNationalCertificate")
                        .HasColumnType("tinyint");

                    b.HasKey("MemberAttachment_ID");

                    b.ToTable("MembersAttachment");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.MembersStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MSTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("MembersStatus");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.PaymentTypes", b =>
                {
                    b.Property<int>("PaymentType_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentType_ID"), 1L, 1);

                    b.Property<string>("PayTypeTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentType_ID");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Publishers", b =>
                {
                    b.Property<int>("Publisher_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_ID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisheAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_ID");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Shelfs", b =>
                {
                    b.Property<int>("Shelf_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shelf_ID"), 1L, 1);

                    b.Property<int?>("Area_ID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Shelf_ID");

                    b.HasIndex("Area_ID");

                    b.ToTable("Shelfs");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Transactions", b =>
                {
                    b.Property<int>("Transaction_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Transaction_ID"), 1L, 1);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Employee_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Library_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Member_ID")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentType_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TransactionType_ID")
                        .HasColumnType("int");

                    b.HasKey("Transaction_ID");

                    b.HasIndex("Employee_ID");

                    b.HasIndex("Library_ID");

                    b.HasIndex("Member_ID");

                    b.HasIndex("PaymentType_ID");

                    b.HasIndex("TransactionType_ID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.TransactionsTypes", b =>
                {
                    b.Property<int>("TransactionType_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionType_ID"), 1L, 1);

                    b.Property<string>("TTTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionType_ID");

                    b.ToTable("TransactionsTypes");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Translators", b =>
                {
                    b.Property<int>("Translator_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Translator_ID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Translator_ID");

                    b.ToTable("Translators");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Areas", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.Libraries", "Libraries")
                        .WithMany()
                        .HasForeignKey("Library_ID");

                    b.Navigation("Libraries");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Authors", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.Publishers", "Publishers")
                        .WithMany()
                        .HasForeignKey("Publisher_ID");

                    b.HasOne("LibraryManage.Entities.DB.Translators", "Translators")
                        .WithMany()
                        .HasForeignKey("Translator_ID");

                    b.Navigation("Publishers");

                    b.Navigation("Translators");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.BookLoans", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.BooksLoansStatus", "BooksLoansStatus")
                        .WithMany()
                        .HasForeignKey("BookLoanStatus_ID");

                    b.HasOne("LibraryManage.Entities.DB.Books_In_Shelfs", "Books_In_Shelfs")
                        .WithMany()
                        .HasForeignKey("BooksInShelf_ID");

                    b.HasOne("LibraryManage.Entities.DB.Members", "Members")
                        .WithMany()
                        .HasForeignKey("Member_ID");

                    b.Navigation("BooksLoansStatus");

                    b.Navigation("Books_In_Shelfs");

                    b.Navigation("Members");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Books", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.Authors", "Authors")
                        .WithMany()
                        .HasForeignKey("Author_ID");

                    b.HasOne("LibraryManage.Entities.DB.BooksStatus", "BooksStatus")
                        .WithMany()
                        .HasForeignKey("Bookstatus_ID");

                    b.HasOne("LibraryManage.Entities.DB.Publishers", "Publishers")
                        .WithMany()
                        .HasForeignKey("Publisher_ID");

                    b.Navigation("Authors");

                    b.Navigation("BooksStatus");

                    b.Navigation("Publishers");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Books_In_Shelfs", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.Books", "Books")
                        .WithMany()
                        .HasForeignKey("Book_ID");

                    b.HasOne("LibraryManage.Entities.DB.BooksStatus", "BooksStatus")
                        .WithMany()
                        .HasForeignKey("Bookstatus_ID");

                    b.HasOne("LibraryManage.Entities.DB.Shelfs", "Shelfs")
                        .WithMany()
                        .HasForeignKey("Shelf_ID");

                    b.Navigation("Books");

                    b.Navigation("BooksStatus");

                    b.Navigation("Shelfs");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.BooksCategories", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.Books", "Books")
                        .WithMany()
                        .HasForeignKey("Book_ID");

                    b.HasOne("LibraryManage.Entities.DB.Categories", "Category")
                        .WithMany()
                        .HasForeignKey("Category_ID");

                    b.Navigation("Books");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Configurations", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.Libraries", "Libraries")
                        .WithMany()
                        .HasForeignKey("Library_ID");

                    b.Navigation("Libraries");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Employees", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.EmployeesRoles", "EmployeesRoles")
                        .WithMany()
                        .HasForeignKey("EmployeeRole_ID");

                    b.HasOne("LibraryManage.Entities.DB.EmployeesStatus", "EmployeesStatus")
                        .WithMany()
                        .HasForeignKey("EmployeeStatus_ID");

                    b.Navigation("EmployeesRoles");

                    b.Navigation("EmployeesStatus");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.MemberLogin", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.Members", "Members")
                        .WithMany()
                        .HasForeignKey("Member_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Members");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Members", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.MembersAttachment", "MembersAttachment")
                        .WithMany()
                        .HasForeignKey("MemberAttachment_ID");

                    b.HasOne("LibraryManage.Entities.DB.MembersStatus", "MembersStatus")
                        .WithMany()
                        .HasForeignKey("MemberStatus_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembersAttachment");

                    b.Navigation("MembersStatus");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Shelfs", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.Areas", "Areas")
                        .WithMany()
                        .HasForeignKey("Area_ID");

                    b.Navigation("Areas");
                });

            modelBuilder.Entity("LibraryManage.Entities.DB.Transactions", b =>
                {
                    b.HasOne("LibraryManage.Entities.DB.Employees", "Employees")
                        .WithMany()
                        .HasForeignKey("Employee_ID");

                    b.HasOne("LibraryManage.Entities.DB.Libraries", "Libraries")
                        .WithMany()
                        .HasForeignKey("Library_ID");

                    b.HasOne("LibraryManage.Entities.DB.Members", "Members")
                        .WithMany()
                        .HasForeignKey("Member_ID");

                    b.HasOne("LibraryManage.Entities.DB.PaymentTypes", "PaymentTypes")
                        .WithMany()
                        .HasForeignKey("PaymentType_ID");

                    b.HasOne("LibraryManage.Entities.DB.TransactionsTypes", "TransactionsTypes")
                        .WithMany()
                        .HasForeignKey("TransactionType_ID");

                    b.Navigation("Employees");

                    b.Navigation("Libraries");

                    b.Navigation("Members");

                    b.Navigation("PaymentTypes");

                    b.Navigation("TransactionsTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
