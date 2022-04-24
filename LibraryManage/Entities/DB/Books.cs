using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace LibraryManage.Entities.DB
{
    public class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Book_ID { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public int? Bookstatus_ID { get; set; } 
        [ForeignKey("Bookstatus_ID")]
        public BooksStatus BooksStatus { get; set; }
        public int? Author_ID { get; set; }
        [ForeignKey("Author_ID")]
        public Authors Authors { get; set; }    
        public int? CurrentStock { get; set; }
        public int? Publisher_ID { get; set; }
        [ForeignKey("Publisher_ID")]
        public Publishers Publishers { get; set; }



    }
}
