using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibraryManage.Entities.DB
{
    public class EmployeesStatus
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeStatus_ID { get; set; }
        public string ESTitle { get; set; }
        public string Description { get; set; }

    }
}
