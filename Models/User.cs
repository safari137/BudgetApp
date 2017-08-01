using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace budget_app.Models
{
    public class User
    {
        public int UserId { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}