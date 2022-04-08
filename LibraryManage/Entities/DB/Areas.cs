using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class Areas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Area_ID { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [ForeignKey("Library_ID")]
        public Libraries Libraries { get; set; }



    }
}
