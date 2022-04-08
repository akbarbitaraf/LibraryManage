using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace LibraryManage.Entities.DB
{
    public class Configurations
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Configuration_ID { get; set; }
        public string ConfigurationTitle { get; set; }  
        public int AllowedLoanDays { get; set; }    
        public int AllowedLoanNumberBook { get; set; }  
        public decimal MulctDelayOneDayPrice { get; set; }
        [ForeignKey("Library_ID")] 
        public Libraries Libraries { get; set; }    

    }
}
