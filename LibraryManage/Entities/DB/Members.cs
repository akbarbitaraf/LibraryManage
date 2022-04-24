using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace LibraryManage.Entities.DB
{
    public class Members
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Member_ID { get; set; }
        public DateTime? CreatedDate { get; set;}
        public DateTime? UpdatedDate { get; set;} = DateTime.Now;
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public int LastName { get; set; }
        public string EmailAddress { get; set; }
        public int? PhoneNumber { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        public Boolean Gender { get; set; }
        public int? Tel { get; set; }
        public int MemberStatus_ID { get; set; }    
        [ForeignKey("MemberStatus_ID")]
        public MembersStatus MembersStatus { get; set; }
        public int MemberAttachment_ID { get; set; }    
        [ForeignKey("MemberAttachment_ID")]
        public MembersAttachment MembersAttachment { get; set; }


    }
}
