using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class Libraries
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Library_ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(300)]
        public string Address { get; set; }
        [StringLength(11)]
        public string Phone { get; set; }
        [StringLength(11)]
        public string Tel { get; set; }

    }
}
