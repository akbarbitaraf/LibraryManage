using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class EmployeeLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int EmployeeLogin_ID { get; set; }
        public string UserName { get; set; }    
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Employee_ID { get; set; }
        [ForeignKey("Employee_ID")]
        public Employees Employees { get; set; }    

    }
}
