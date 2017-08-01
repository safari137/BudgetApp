using System.ComponentModel.DataAnnotations;

namespace budget_app.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public decimal Amount { get; set; }

        public TransactionType TransactionType { get; set; }

        [MaxLength(255)]
        public string Note { get; set; }

        public int EnvelopeId { get; set; }

        public virtual Envelope Envelope { get; set; }        
    }

    public enum TransactionType 
    {
        Deposit = 1,
        Withdraw =2
    }
}