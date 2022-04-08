using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LibraryManage.Entities.DB
{
    public class BooksLoansStatus
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookLoanStatus_ID { get; set;  }
        public string Title { get; set; }

    }
}
