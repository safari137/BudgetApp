using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace budget_app.Models
{
    public class Envelope
    {
        public int EnvelopeId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}