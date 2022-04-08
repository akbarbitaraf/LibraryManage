﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace LibraryManage.Entities.DB
{
    public class BookLoans
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookLoan_ID { get; set; }
        public DateTime? ReceivedDate { get; set;}
        public DateTime? ReturnDate { get; set; }
        [ForeignKey("BookLoanStatus_ID")]
        public BooksLoansStatus BooksLoansStatus { get; set; }  
        [ForeignKey("BooksInShelf_ID")]
        public Books_In_shelfs Books_In_Shelfs { get; set; }
        [ForeignKey("Member_ID")]
        public Members Members { get; set; }
        public int? MulcCurrentDelay { get; set; }
        public DateTime? ReturnMulctDate { get; set; }

    }
}
