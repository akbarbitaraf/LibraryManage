using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace LibraryManage.Entities.DB
{
    public class MembersAttachment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberAttachment_ID { get; set; }
        public byte MASelfImage { get; set; }
        public byte MASelfBirthCertificate { get; set;  }
        public byte MASelfNationalCertificate { get; set; }
        public byte MAGuarantor { get; set;  }

    }
}
