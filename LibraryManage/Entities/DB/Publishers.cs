using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class Publishers
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Publisher_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PublisherAddress { get; set; }


    }
}
