using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class Shelfs
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Shelf_ID { get; set; }   
        public string Title { get; set; }
        public int? Area_ID { get; set; }    
        [ForeignKey("Area_ID")]
        public Areas Areas { get; set; }
    }
}