using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class Messages
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Messages_ID { get; set; }
        public string Text { get; set; }
        public BookLoans IsSend { get; set; }   
        public DateTime SendDate { get; set; }

        [ForeignKey("Member_ID")]
        public Members Members { get; set; }
    }
}
