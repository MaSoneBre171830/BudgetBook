using BudgetBook.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BudgetBook.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Food", Type = TransactionType.Expense , IsActive = true},
                new Category { Id = 2, Name = "Transport", Type = TransactionType.Expense , IsActive = true},
                new Category { Id = 3, Name = "Salary", Type = TransactionType.Income , IsActive = true},
                new Category { Id = 4, Name = "Other Income", Type = TransactionType.Income , IsActive = true}
            );
        }
    }
}
