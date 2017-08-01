using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace budget_app.Models
{
    public class Account
    {
        public int AccountId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Envelope> Envolopes { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}