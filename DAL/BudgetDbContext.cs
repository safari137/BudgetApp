using budget_app.Models;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace budget_app.DAL
{
    public class BudgetDbContext : DbContext
    {
        // public BudgetDbContext(DbContextOptions<BudgetDbContext> options) : base(options)
        // {           
        // }

        public DbSet<User> Users { get; set; }

        public DbSet<Envelope> Envelopes { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySQL(@"server=localhost;userid=budgetapp;password=testing123;database=budgetapp;");

        protected override void OnModelCreating(ModelBuilder builder) 
        {            
            builder.Entity<Account>()
                .HasOne(a => a.User)
                .WithMany(u => u.Accounts)
                .HasForeignKey(a => a.UserId);

            builder.Entity<Envelope>()
                .HasMany(e => e.Transactions)
                .WithOne(t => t.Envelope)
                .HasForeignKey(t => t.EnvelopeId);        

            builder.Entity<Envelope>()
                .HasOne(e => e.Account)
                .WithMany(a => a.Envolopes)
                .HasForeignKey(a => a.AccountId);

            base.OnModelCreating(builder);
        }
    }
}