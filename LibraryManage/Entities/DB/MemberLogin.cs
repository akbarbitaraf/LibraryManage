using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class MemberLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int MemberLogin_ID { get; set; }
        public string UserName { get; set; }    
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Member_ID { get; set; }
        [ForeignKey("Member_ID")]
        public Members Members { get; set; }    

    }
}
