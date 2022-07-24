using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class Translators
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Translator_ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string? Mobile { get; set; }
        public string? Phone { get; set; }
        public string? Description { get; set; }
        public bool Gender { get; set; }


    }
}
