using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class PaymentTypes
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentType_ID { get; set; }
        public string PayTypeTitle { get; set; }    


    }
}
