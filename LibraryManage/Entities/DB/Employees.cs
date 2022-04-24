using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class Employees
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Employee_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? EmployeeStatus_ID { get; set; }  
        [ForeignKey("EmployeeStatus_ID")]
        public EmployeesStatus EmployeesStatus { get; set; }
        public int? EmployeeRole_ID { get; set; }    
        [ForeignKey("EmployeeRole_ID")]
        public EmployeesRoles EmployeesRoles { get; set; }
    }
}
