using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace LibraryManage.Entities.DB
{
    public class Books_In_Shelfs
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BooksInShelf_ID { get; set; }    
        [ForeignKey("Book_ID")]
        public Books Books { get; set; }    
        [ForeignKey("Shelf_ID")]
        public Shelfs Shelfs { get; set; }
        public string ISBN { get; set; }
        [ForeignKey("Bookstatus_ID")]
        public BooksStatus BooksStatus { get; set; }


    }
}
