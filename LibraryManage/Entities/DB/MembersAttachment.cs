using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace Library.Entities.DB
{
    public class MembersAttachment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public Byte MASelfImage { get; set; }
        public byte MASelfBirthCertificate { get; set;  }
        public byte MASelfNationalCertificate { get; set; }
        public byte MAGuarantor { get; set;  }

    }
}
