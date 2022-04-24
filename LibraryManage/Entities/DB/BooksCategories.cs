using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace LibraryManage.Entities.DB
{
    public class BooksCategories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int BooksCategory_ID { get; set; }
        public int? Category_ID { get; set; }    
        [ForeignKey("Category_ID")]
        public Categories Category { get; set;}
        public int? Book_ID { get; set; }    
        [ForeignKey("Book_ID")]
        public Books Books { get; set; }


    }
}
