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

        [ForeignKey("PaymentType_ID")]
        public PaymentTypes PaymentTypes { get; set; }
        [ForeignKey("TransactionType_ID")]
        public TransactionsTypes TransactionsTypes { get; set; }
        [ForeignKey("Employee_ID")]
        public Employees Employees { get; set; }
        [ForeignKey("Library_ID")]
        public Libraries Libraries { get; set; }
        [ForeignKey("Member_ID")]
        public Members Members { get; set; }

    }
}
