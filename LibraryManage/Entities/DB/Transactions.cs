using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManage.Entities.DB
{
    public class Transactions
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Transaction_ID { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public int? PaymentType_ID { get; set; } 
        [ForeignKey("PaymentType_ID")]
        public PaymentTypes PaymentTypes { get; set; }
        public int? TransactionType_ID { get; set; } 
        [ForeignKey("TransactionType_ID")]
        public TransactionsTypes TransactionsTypes { get; set; }
        public int? Employee_ID { get; set; }    
        [ForeignKey("Employee_ID")]
        public Employees Employees { get; set; }
        public int? Library_ID { get; set; } 
        [ForeignKey("Library_ID")]
        public Libraries Libraries { get; set; }
        public int? Member_ID { get; set; }  
        [ForeignKey("Member_ID")]
        public Members Members { get; set; }

    }
}
