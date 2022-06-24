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
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        [StringLength(2000)]
        public string Address { get; set; }
        public Boolean Gender { get; set; }
        public string Mobile { get; set; }
        public int? EmployeeStatus_ID { get; set; }  
        [ForeignKey("EmployeeStatus_ID")]
        public EmployeesStatus EmployeesStatus { get; set; }
        public int? EmployeeRole_ID { get; set; }    
        [ForeignKey("EmployeeRole_ID")]
        public EmployeesRoles EmployeesRoles { get; set; }
    }
}
