using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class Authors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Author_ID { get; set; }
        [StringLength(50)]
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public Boolean AuthorGender { get; set; }
        public int? Translator_ID { get; set; }
        [ForeignKey("Translator_ID")]
        public Translators Translators { get; set; }    
        public int? Publisher_ID { get; set; }   
        [ForeignKey("Publisher_ID")]
        public Publishers Publishers { get; set; }  

             

    }
}
