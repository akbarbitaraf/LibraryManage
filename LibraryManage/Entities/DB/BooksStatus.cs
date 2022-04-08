using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace LibraryManage.Entities.DB
{
    public class BooksStatus
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Bookstatus_ID { get; set; }  
        public string Title { get; set; }

    }
}
